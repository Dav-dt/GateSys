using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;


//classe dédiée a la gestion du style glboal de l'appli
namespace saeStargateTUAILLON_LONGO_YURTSEBEN
{
    internal class Style
    {
        private Style() { }

        //ca crash sinon si ce nest pas statique
        private static PrivateFontCollection m_privateFontCollection =
            new PrivateFontCollection();
        private static Font m_font;

        private static Color m_couleurPrimaire  = Color.FromArgb(21, 19, 30);
        private static Color m_couleurSecondaire = Color.FromArgb(45, 56, 76);
        private static Color m_couleurTexte = Color.FromArgb(243, 214, 144);
        private static Color m_couleurTitre = Color.FromArgb(253, 128, 02);
        private static Color m_survolage = Color.FromArgb(67, 72, 102);

        // appliquer un style spécifique a tous les cotrls
        public static void InitControles(Form frm)
        {
            string path = Path.Combine(Application.StartupPath,
                "fonts", "Saira_Condensed-Regular.ttf");

            m_privateFontCollection.AddFontFile(path);
            m_font = new Font(m_privateFontCollection.Families[0], 
                13, FontStyle.Regular);

            frm.Icon = Properties.Resources.imgIco;
            frm.AutoScaleMode = AutoScaleMode.None;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;

            frm.MaximizeBox = false; //enleber le plein ecran
            //appel de la fonction pour appliquer style a tous les ctrl
            ApplyStyleRecursive(frm, m_font);
        }

        private static void ApplyStyleRecursive(Control parent, Font font)
        {
            if (!(parent is RichTextBox))
            {
                parent.Font = font;
            }
            parent.BackColor = m_couleurPrimaire;

            if ( parent is Button btn )
            {
                btn.UseCompatibleTextRendering = true;
                btn.BackColor = m_couleurSecondaire;
                btn.ForeColor = m_couleurTexte;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;
                btn.Font = new Font(font.FontFamily,
                font.Size, FontStyle.Bold);

                btn.MouseEnter += new EventHandler(survolBouton);
                btn.MouseLeave += new EventHandler(quitterSurvolBouton);
            }
            else if ( parent is Label lbl )
            {
                lbl.ForeColor = m_couleurTexte;
                lbl.UseCompatibleTextRendering = true;
                lbl.Font = new Font(font.FontFamily,
                    font.Size, FontStyle.Bold);
            }
            else if ( parent is TextBox txt)
            {
                txt.BackColor = m_couleurSecondaire;
                txt.ForeColor = m_couleurTexte;
                txt.BorderStyle = BorderStyle.FixedSingle;
            }
            else if ( parent is ComboBox cmb)
            {
                cmb.BackColor = m_couleurSecondaire;
                cmb.ForeColor = m_couleurTexte;
            }
            else if ( parent is Panel pnl )
            {

            }
            else if ( parent is GroupBox grp )
            {
                grp.ForeColor = m_couleurTitre;
                grp.Font = new Font(font.FontFamily,
                    font.Size, FontStyle.Bold);
            }
            else if (parent is CheckBox chk)
            {
                chk.ForeColor = m_couleurTexte;
                chk.UseCompatibleTextRendering = true;
                chk.Font = new Font(font.FontFamily,
                    font.Size, FontStyle.Bold);
                
            }

            else if ( parent is ListBox lst )
            {
                foreach ( String item in lst.Items )
                {
                    lst.BackColor = m_couleurSecondaire;
                    lst.ForeColor = m_couleurTexte;
                }
            }

                //a ajouter : le tab control, datagrid view

                foreach (Control child in parent.Controls)
                {
                    ApplyStyleRecursive(child, font);
                }
        }

        private static void survolBouton(object sender, EventArgs e)
        {
            if ( sender is Button btn )
            { btn.BackColor = m_survolage;
                btn.Size = new Size(btn.Size.Width +2, btn.Size.Height +2);
            }        
        }

        private static void quitterSurvolBouton(object sender, EventArgs e)
        {
            if ( sender is Button btn )
            { btn.BackColor = m_couleurSecondaire;
                btn.Size = new Size(btn.Size.Width-2, btn.Size.Height-2);
            }
        }
    }
}
