using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.IO.Directory;

namespace copyfile
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main_menu());
        }
    }
    /* ==============================================================
     * 入力ファイルの操作に関するクラス
     * =============================================================*/
     class FileControl
    {
        private string input_data_path;
        
        // このソフトのおいてあるディレクトリのdataフォルダをセット
        // 戻り値：ソフトカレントdir + "\data"
        private void GetDataPath() {
            input_data_path = GetCurrentDirectory() + "\\data";
        }

        // ソフトのカレントディレクトリにdataがあるか判定し、値をセット
        // 戻り値：(dataフォルダあるとき)ソフトカレントdir + "\data"
        //         (dataフォルダないとき)dataフォルダがありません"
        public string SetDataPath()
        {
            GetDataPath();

            if (!(System.IO.Directory.Exists(input_data_path)))
            {
                input_data_path = "dataフォルダがありません";
            }

            return input_data_path;
        }
    }
}
