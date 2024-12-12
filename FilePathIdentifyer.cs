using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCV_LIB
{
    public class FilePathIdentifyer
    {
        // Hard-coded list of paths
        public static List<string> GetPaths()
        {
            return new List<string>
            {
                "ALL",
                // @"C:\_____Ufake\SVN_Projects",
                //@"C:\_____Ufake\SVN_BaseLineCode",
                //@"C:\_____Ufake\Code_Source",

                //@"C:\_____Ufake\Code_Source\CANtrak",
                //@"C:\_____Ufake\Code_Source\TI",
                //@"C:\_____Ufake\Code_Source\Tern",
                //@"C:\_____Ufake\Code_Source\MBIV",
                //@"C:\_____Ufake\Code_Source\Atmel",

                //@"C:\____SVN_vcinc_2023\",

                //@"C:\____SVN_vcinc_2023\projects",
                //@"C:\____SVN_vcinc_2023\baseline_code",
                // too big AVOID this : @"U:\Code_Source",

                //@"C:\____SVN_vcinc_2023\projects",
                //@"C:\____SVN_vcinc_2023\baseline_code",

                //@"U:\Code_Source\TI",
                //@"U:\Code_Source\Tern",
                //@"U:\Code_Source\MBIV",
                //@"U:\Code_Source\Atmel",
                //@"U:\Code_Source\CANtrak",


                //LAST WORKING TEST 
                //@"C:\____SVN_vcinc_2023\",
                // @"U:\Code_Source",
                 @"C:\_____UfakeminiDir1",
                @"C:\_____UfakeminiDir2",
                @"C:\_____UfakeminiDir3",


                // @"C:\_____Ufakemini\SVN_Projects",
                //@"C:\_____Ufakemini\SVN_BaseLineCode",
                //@"C:\_____Ufakemini\Code_Source",
            };
        }
    }
}

