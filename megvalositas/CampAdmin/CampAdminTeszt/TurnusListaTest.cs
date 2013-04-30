using AdminFelulet.TaborVezeto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CampLogic.TaborvezetoFunkciok;
using CampLogic.Borders;

namespace CampAdminTeszt
{


    /// <summary>
    ///This is a test class for TurnusListaTest and is intended
    ///to contain all TurnusListaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TurnusListaTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class

        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {

            FeluletHozzafero.SetByVezető(
                new Vezeto
                {
                    Tipus = VezetoTipus.TaborVezeto
                });

        }

        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AktivitásBeállít
        ///</summary>


        DateTime MostUtán = DateTime.Today.AddDays(1);
        DateTime MostUtánUtán = DateTime.Today.AddDays(5);


        DateTime MostElött = DateTime.Today.AddDays(-1);
        DateTime MostElöttElött = DateTime.Today.AddDays(-5);

        DateTime Most = DateTime.Today;




        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_AktivMégNemFutó()
        {
            Turnus t = new Turnus { Aktív = true, Kezdes = MostUtán, Befejezes = MostUtánUtán };
            bool elvárt = false;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);
        }


        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_AktívMaIndulóTurnus()
        {
            Turnus t = new Turnus { Aktív = true, Kezdes = Most, Befejezes = MostUtán };
            bool elvárt = true;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);


        }


        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_AktívFutóTurnus()
        {
            Turnus t = new Turnus { Aktív = true, Kezdes = Most, Befejezes = MostUtán };
            bool elvárt = true;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);


        }


        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_AktívMaLejáró()
        {
            Turnus t = new Turnus { Aktív = true, Kezdes = MostElött, Befejezes = Most };
            bool elvárt = true;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);


        }


        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_AktívLejárt()
        {
            Turnus t = new Turnus { Aktív = true, Kezdes = MostElöttElött, Befejezes = MostElött };
            bool elvárt = false;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);


        }

        //------------------

        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_InaktívMégNemFutó()
        {
            Turnus t = new Turnus { Aktív = false, Kezdes = MostUtán, Befejezes = MostUtánUtán };
            bool elvárt = false;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);


        }


        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_InaktívMaIndulóTurnus()
        {
            Turnus t = new Turnus { Aktív = false, Kezdes = Most, Befejezes = MostUtán };
            bool elvárt = true;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);


        }


        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_InaktívFutóTurnus()
        {
            Turnus t = new Turnus { Aktív = false, Kezdes = MostElött, Befejezes = MostUtán };
            bool elvárt = true;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);


        }


        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_InaktívMaLejáró()
        {
            Turnus t = new Turnus { Aktív = false, Kezdes = MostElött, Befejezes = Most };
            bool elvárt = true;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);


        }


        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_InaktívLejárt()
        {
            Turnus t = new Turnus { Aktív = false, Kezdes = MostElöttElött, Befejezes = MostElött };
            bool elvárt = false;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);


        }


        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_AktívMaMa()
        {
            Turnus t = new Turnus { Aktív = true, Kezdes = Most, Befejezes = Most };
            bool elvárt = true;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);


        }

        [TestMethod()]
        [DeploymentItem("AdminFelulet.exe")]
        public void AktivitásBeállítTest_InaktívMaMa()
        {
            Turnus t = new Turnus { Aktív = false, Kezdes = Most, Befejezes = Most };
            bool elvárt = true;

            //tesztelendő
            TurnusLista_Accessor.AktivitásBeállít(t);

            //tesztelés
            Assert.AreEqual(elvárt, t.Aktív);


        }

    }
}
