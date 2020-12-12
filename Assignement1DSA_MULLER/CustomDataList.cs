using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1DSA_MULLER
{
    public class CustomDataList
    {
        private List<Student> dataList;

        //Constructor
        public CustomDataList()
        {
            this.dataList = new List<Student>();
        }

        //Property
        public List<Student> DataList
        {
            get { return this.dataList; }
        }

        //Methods
        /// <summary>
        /// Used to populate some sample data
        /// </summary>
        public void PopulateWithSampleData()
        {
            Student student1 = new Student("Albert", "Ducret", "H24IG", 62.10f);
            Student student2 = new Student("Georges", "Treillaud", "Q267G", 50.44f);
            Student student3 = new Student("Robert", "Codet", "2H3K4", 100f);
            Student student4 = new Student("Lucie", "Humblot", "KLMN3", 76.09f);

            this.dataList.Add(student1);
            this.dataList.Add(student2);
            this.dataList.Add(student3);
            this.dataList.Add(student4);
        }
        
        /// <summary>
        /// Add an element to the list
        /// </summary>
        /// <param name="element">student instance</param>
        public void Add(Student element)
        {
            this.dataList.Add(element);
        }

        /// <summary>
        /// Display the information of an element 
        /// </summary>
        /// <param name="index">Index of the element</param>
        public void GetElement(int index)
        {
            Console.WriteLine(dataList[index - 1].ToString());
        }

        /// <summary>
        /// Remove an element from the list
        /// </summary>
        /// <param name="index">Index of the element</param>
        public void RemoveByIndex(int index)
        {
            dataList.RemoveAt(index - 1);
        }

        /// <summary>
        /// Remove the first element of the list
        /// </summary>
        public void RemoveFirst()
        {
            dataList.RemoveAt(0);
        }

        /// <summary>
        /// Remove the last element of the list
        /// </summary>
        public void RemoveLast()
        {
            dataList.RemoveAt(dataList.Count - 1);
        }

        /// <summary>
        /// Display all elements of the list
        /// </summary>
        public void DisplayList()
        {
            for(int i = 0; i<dataList.Count; i++)
            {
                Console.WriteLine(dataList[i].ToString());
            }
        }
    }
}
