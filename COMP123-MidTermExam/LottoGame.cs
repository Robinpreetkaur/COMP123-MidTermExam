﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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
           m_elementNumber= new ElementNumber();
            m_random= new  random();
           m_numberList= new NumberList();
        }
        

        //  private _build method 
        private void m_build()
        {
         for(int num=1; num < SetSize; num++) 
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

        // CREATE the public PickElements method here ----------------------------
    }
}
