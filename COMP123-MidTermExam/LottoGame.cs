////--------------------------------------
//// Author's Name : Robinpreet kaur
///  Author’s student number :301100296 
///  Date last Modified : 17 July,2020 
///  Program description : abstract class-- LottoGame , Interface---- IGenerateLottoNumber   subclasses--LottoMax , Lotto649
/// ------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        
        private List<int> m_elementList;
        private int m_elementNumber;
        private List<int> m_numberList;
        private Random m_random;
        private int m_setSize;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public List<int> ElementList{
           get
            {
                return m_elementList;
            }
         }
        public int ElementNumber {
            get
            {
                   return m_elementNumber;
            } 
            
            set
            {
                m_elementNumber= value;

            }
        }
        public List<int> NumberList {
            get
              {
                return m_numberList;
             }
        }
        public Random random{
            get
            {
                return m_random;
            }
        }
        public int SetSize {
            get
            {
                return m_setSize;
            }
            set
            {
                m_setSize= value;
            }
        }
       
        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
       



        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this.m_initialize();

            // call the _build method
            this.m_build();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // private _initialize method 

        private void m_initialize()
        {
            //instantiate new objects for private fields 
          List <int> m_elementNumber= new List<int>();
            m_random= new  Random();
          List <int> m_numberList= new List<int>();
        }
        

        //  private _build method 
        private void m_build()
        {
            //for loop to add integers in NumberList  
         for(int num=1; num <= SetSize; num++) 
            {
                NumberList.Add(num);
            }
        }

        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }

         

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // public PickElements method ----------------------------

        public void PickElements()
        {
            //checking if list is not empty 
          if (ElementList.Count>0 ) 
             {    
               //then clear method is called by both the lists
                 ElementList.Clear();
                 NumberList.Clear();
             }
          //m_build is called to rebuilt the NumberList
            m_build();

          m_random rn = new Random();
            //loop is created to generate random numbers 
            for (int randomNumber = 1; randomNumber <= elementNumber ; randomNumber++)
            {
                // it will select element from ElementList
             int  number = rn.Next (1, ElementList.Count);
                //Remove the selected element from ElementList
                ElementList.Remove(number);
                //Add the element in NumberList
                NumberList.Add(number); 
        
        }
    }
}
}
