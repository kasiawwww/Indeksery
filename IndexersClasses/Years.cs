using System;
using System.Collections.Generic;
using System.Text;

namespace IndexersClasses
{
    public class Year

    {
        public string[] Names { get; set; }
        private int[] Years;
        public int Count => Years.Length;

        public Year(int numberOfValues)
        {
        }
        private int GetYear(string name)
        {
            for (int j = 0; j < Names.Length; j++)
            {
                if (Names[j] == name)
                {
                    return Years[j];
                }
            }
            throw new System.ArgumentOutOfRangeException();

        }

        public int this[string name]
        {
            get
            {
                return (GetYear(name));
            }
            set => Years[name] = value;
        }

    }
}
