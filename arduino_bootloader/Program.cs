/* 
 * FTH Sim Racing
 * 
 * https://linktr.ee/fthsimracing
 *  
 * DSE Diy Sim Equipment
 * 
 * https://linktr.ee/dseracing
 * 
 * KAMY Engineering
 * 
 * https://linktr.ee/kamyengineering
 * 
 * Christophe Diericx
 * 
 * https://github.com/twinearthsoftware/ArduinoSketchUploader
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduino_bootloader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new bootloader());
        }
    }
}
