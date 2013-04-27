using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Borders
{
    public class FelületHozzáférő
    {

        private FelületHozzáférő()
        {

        }

        private static IIfjúságiVezetőiKezelő instance;

        public static IIfjúságiVezetőiKezelő Instance
        {
            get
            {
                //lazy loading, illetve default viselkedés amennyiben nem lett inicializálva a SetByVezető metódussal
                if (instance == null)
                {
                    SetAsIfiVez();
                }

                return FelületHozzáférő.instance;
            }
        }

        private static void SetAsIfiVez()
        {
            instance = new IfjúságiVezetőiKezelőFelület();
        }

        private static void SetAsKcsVez()
        {
            instance = new KorcsoportVezetőiKezelőFelület();
        }

        private static void SetAsTbVez()
        {
            instance = new TáborvezetőiKezelőFelület();
        }


        public static void SetByVezető(Vezető vezető)
        {
            switch (vezető.Tipus)
            {
                case VezetőTípus.IfjúságiVezető:
                    SetAsIfiVez();
                    break;

                case VezetőTípus.KorcsoportVezető:
                    SetAsKcsVez();
                    break;

                case VezetőTípus.TáborVezető:
                    SetAsTbVez();
                    break;

                default:
                    SetAsIfiVez();
                    break;
            }
        }

    }
}
