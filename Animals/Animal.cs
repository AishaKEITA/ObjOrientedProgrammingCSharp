using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objprogramming.Animals
{
    internal class Animal
    {
        //fields
        private int id;
        private int age;
        private string name;
        private string gender;
        private string skinColor;

        /// <summary>
        /// method to get id
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// method to set id
        /// </summary>
        /// <param name="id"></param>
        public void SetId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// method to get and set name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// method to get age
        /// </summary>
        /// <returns></returns>
        public int GetAge()
        {
            return age;
        }

        /// <summary>
        /// method to set age
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public void SetAge(int age)
        {
            if (age <= 0)
            {
                this.age = age;
            }
        }

        /// <summary>
        /// method to set and get skin color
        /// </summary>
        public string SkinColor
        {
            get { return skinColor; }
            set { skinColor = value; }
        }
    }
}
