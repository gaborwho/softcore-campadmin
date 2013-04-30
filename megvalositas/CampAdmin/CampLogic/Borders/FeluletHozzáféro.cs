using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampLogic.Borders
{
    public class FeluletHozzáféro
    {

        private FeluletHozzáféro()
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

                return FeluletHozzáféro.instance;
            }
        }

        private static void SetAsIfiVez()
        {
            instance = new IfjuságiVezetoiKezeloFelulet();
        }

        private static void SetAsKcsVez()
        {
            instance = new KorcsoportVezetoiKezeloFelület();
        }

        private static void SetAsTbVez()
        {
            instance = new TáborvezetoiKezeloFelulet();
        }


        public static void SetByVezető(Vezetö vezető)
        {
            switch (vezető.Tipus)
            {
                case VezetoTípus.IfjúságiVezető:
                    SetAsIfiVez();
                    break;

                case VezetoTípus.KorcsoportVezető:
                    SetAsKcsVez();
                    break;

                case VezetoTípus.TáborVezető:
                    SetAsTbVez();
                    break;

                default:
                    SetAsIfiVez();
                    break;
            }
        }

    }
}
