////--------------------------------------
//// Author's Name : Robinpreet kaur
///  Author’s student number :301100296 
///  Date last Modified : 17 July,2020 
///  Program description : abstract class-- LottoGame , Interface---- IGenerateLottoNumber   subclasses--LottoMax , Lotto649
/// ----------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame,IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            :base(7,49)
        {
             
        }

        //  GenerateLottoNumbers method 

        public void GenerateLottoNumbers()// method with body 
        {
            // call method of superclass
            base.PickElements();
            random r=new Random();
            for(int ranNumber=1 ; ranNumber <= 7 ; ranNumber++ )
            {
            int rMax = r.Next(1,49);
            Console.WriteLine(rMax.ToString());
            }
            
        }
    }
}