using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampLogic.Borders
{
    public class FeluletHozzafero
    {

        private FeluletHozzafero()
        {

        }

        private static IIfjusagiVezetoiKezelo instance;

        public static IIfjusagiVezetoiKezelo Instance
        {
            get
            {
                //lazy loading, illetve default viselkedés amennyiben nem lett inicializálva a SetByVezető metódussal
                if (instance == null)
                {
                    SetAsIfiVez();
                }

                return FeluletHozzafero.instance;
            }
        }

        private static void SetAsIfiVez()
        {
            instance = new IfjusagiVezetoiKezeloFelulet();
        }

        private static void SetAsKcsVez()
        {
            instance = new KorcsoportVezetoiKezeloFelulet();
        }

        private static void SetAsTbVez()
        {
            instance = new TaborvezetoiKezeloFelulet();
        }


        public static void SetByVezető(Vezeto vezeto)
        {
            switch (vezeto.Tipus)
            {
                case VezetoTipus.IfjusagiVezeto:
                    SetAsIfiVez();
                    break;

                case VezetoTipus.KorcsoportVezeto:
                    SetAsKcsVez();
                    break;

                case VezetoTipus.TaborVezeto:
                    SetAsTbVez();
                    break;

                default:
                    SetAsIfiVez();
                    break;
            }
        }

    }
}
