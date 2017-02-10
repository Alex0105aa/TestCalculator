using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCalculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestOutputer
    {

        [TestMethod]
        public void TestCollectionMyelementExist()
        {

            // Object type of all data

            List<MyElement> list_of_myelements = new List<MyElement>();

            MyElement elm_1 = new MyElement();
            MyElement elm_2 = new MyElement();
            MyElement elm_3 = new MyElement();

            elm_2 = null; // lose pointer on data element 2

            list_of_myelements.Add(elm_1);
            list_of_myelements.Add(elm_2);
            list_of_myelements.Add(elm_3);



            // object.GetType() return type of element

            CollectionAssert.AllItemsAreNotNull(list_of_myelements);

        }



        [TestMethod]
        public void TestCollectionEqualToOtherOrder()
        {
            List<string> list_of_string_test = new List<string>();

            list_of_string_test.Add("Abrasha");
            list_of_string_test.Add("Ivanov");
            list_of_string_test.Add("Petrov");


            List<string> list_of_string_expected = new List<string>();

            list_of_string_expected.Add("Abrasha");
            list_of_string_expected.Add("Ivanov");
            list_of_string_expected.Add("Petrov");




            CollectionAssert.AreEqual(list_of_string_expected, list_of_string_test);
        }



    }
}



