////--------------------------------------
//// Author's Name : Robinpreet kaur
///  Author’s student number :301100296 
///  Date last Modified : 17 July,2020 
///  Program description : abstract class-- LottoGame , Interface---- IGenerateLottoNumber   subclasses--LottoMax , Lotto649
/// ---------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This class is a subclass of the LottoGame abstract superclass
     * </summary>
     * 
     * @class Lotto649
     */
    public class Lotto649 : LottoGame,IGenerateLottoNumbers
    {
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public Lotto649()
            : base(6, 49)
        {

        }

        //  GenerateLottoNumbers method ----------------
        public void GenerateLottoNumbers() // interface method with body(defination)
        {
            //calling a method of superclass
            base.PickElements();
            random r=new Random();
            for(int ranNumber=1 ; ranNumber <= 6 ; ranNumber++ )
            {
            int r649 = r.Next(1,49);
            Console.WriteLine(r649.ToString());
            }
            
        
        }
    }
}
