using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    internal class Statistique
    {
        private SQLiteConnection connection = Connexion.Connec;

        public DataTable getMenbre()
        {
            string request = $@"select nom||' '||prenom as nom,matricule
                                from Membre";
            SQLiteCommand cmd = new SQLiteCommand(request, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }

        public DataTable getColege(string id)
        {
            string request = $@"SELECT M.nom, M.prenom, 'Militaire' AS Type
                                FROM Composer C1
                                INNER JOIN Composer C2 ON C1.nomPlanete = C2.nomPlanete AND C1.numeroMission = C2.numeroMission
                                INNER JOIN Membre M ON C2.matriculeMembre = M.matricule
                                INNER JOIN Militaire Mil ON M.matricule = Mil.matriculeMembre
                                WHERE  C1.matriculeMembre = '{id}'AND C2.matriculeMembre != '{id}'
                                UNION
                                SELECT M.nom, M.prenom, 'Civil' AS Type
                                FROM Composer C1
                                INNER JOIN Composer C2 ON C1.nomPlanete = C2.nomPlanete AND C1.numeroMission = C2.numeroMission
                                INNER JOIN Membre M ON C2.matriculeMembre = M.matricule
                                INNER JOIN Civil Civ ON M.matricule = Civ.matriculeMembre
                                WHERE C1.matriculeMembre = '{id}'AND C2.matriculeMembre != '{id}'";
            SQLiteCommand cmd = new SQLiteCommand(request, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getMissionPlanete()
        {
            string request = $@"SELECT P.nom AS Planete, COUNT(M.numero) AS NombreDeMissions
                                FROM Planete P
                                LEFT JOIN Mission M ON P.nom = M.nomPlanete
                                GROUP BY P.nom;";
            SQLiteCommand cmd = new SQLiteCommand(request, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable DatagetBudget()
        {
            string request = $@"SELECT  M.nomPlanete, M.numero, 
                            (SELECT COUNT(*) FROM Composer C WHERE C.nomPlanete = M.nomPlanete AND C.numeroMission = M.numero) AS Membres,
                            M.budget,
                            M.budget - (SELECT SUM(montant) FROM Depense D WHERE D.nomPlanete = M.nomPlanete AND D.numeroMission = M.numero) AS BudgetActuel
                            FROM Mission M
                            WHERE (SELECT COUNT(*) FROM Composer C WHERE C.nomPlanete = M.nomPlanete AND C.numeroMission = M.numero) > 1;";
            SQLiteCommand cmd = new SQLiteCommand(request, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getBudgetDetail(string nomPlanete, int numeroMission)
        {
            string request = $@"SELECT D.motif, D.montant
                                FROM Depense D
                                WHERE D.nomPlanete = '{nomPlanete}' AND D.numeroMission = {numeroMission};";
            SQLiteCommand cmd = new SQLiteCommand(request, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getDepenseMax()
        {
            string request = $@"select d.nomPlanete||'-'||d.numeroMission||' '||d.montant||'$ '||d.motif as recap,b.nom,b.prenom
                                from Depense d 
                                join Mission m on  d.nomPlanete = m.nomPlanete and d.numeroMission = m.numero
                                join Membre b on m.matriculeChef = b.matricule
                                where montant >= (SELECT max(montant) from Depense where d.nomPlanete = nomPlanete and d.numeroMission = numeroMission)
                                group by d.nomPlanete,d.numeroMission";
            SQLiteCommand cmd = new SQLiteCommand(request, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getNomMission()
        {
            string request = $@"SELECT nomPlanete||'-'||numero AS nomMission
                                FROM Mission";
            SQLiteCommand cmd = new SQLiteCommand(request, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getInformateurMoins(string nom,int id)
        {
            string request = $@"SELECT I.nomCode, E.nom AS especeOrigine, SUM(C.sommeVersee) AS sommeTotaleRecue,E.couleur
                                FROM Contact C
                                INNER JOIN Informateur I ON C.nomCodeInformateur = I.nomCode
                                INNER JOIN Espece E ON I.idEspeceEnnemi = E.id
                                WHERE C.nomPlanete = '{nom}' AND C.numeroMission = '{id}'
                                GROUP BY I.nomCode, E.nom
                                HAVING SUM(C.sommeVersee) = (
                                        SELECT MIN(TotalParInformateur)
                                        FROM (
                                            SELECT SUM(C2.sommeVersee) AS TotalParInformateur
                                            FROM Contact C2
                                            WHERE C2.nomPlanete = '{nom}' AND C2.numeroMission = '{id}'
                                            GROUP BY C2.nomCodeInformateur
                                        ) AS Totaux
                                    );";
            SQLiteCommand cmd = new SQLiteCommand(request, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
    
}
