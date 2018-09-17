using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TIC19.MyClass
{
    class TemplateLoader
    {
        private Form1 mainForm;

        public TemplateLoader(Form1 form1)
        {
            mainForm = form1;
        }

        public void Load(int templateType)
        {
            switch(templateType)
            {
                case 0: // Weapon
                {

                    break;
                }
                case 1: // Armor
                {

                    break;
                }
                case 2: // Gem
                {

                    break;
                }
                case 3: // Projectile
                {

                    break;
                }
                case 4: // Container
                {

                    break;
                }
                case 5: // Quiver
                {

                    break;
                }
                case 6: // Glyph
                {

                    break;
                }
                case 7: // Recipe
                {

                    break;
                }
                case 8: // Quest
                {

                    break;
                }
                case 9: // Key
                {

                    break;
                }
                case 10: // Reagent
                {

                    break;
                }
                case 11: // Trade Good
                {

                    break;
                }
                case 12: // Consumable
                {

                    break;
                }
                case 13: // Miscellaneous
                {

                    break;
                }
            }
        }
    }
}
