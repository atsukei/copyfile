using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.IO.Directory;
using static System.IO.File;

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
    /  入力ファイルの操作に関するクラス
    /  =============================================================*/
     class InputFileControl
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

    /* ==============================================================
    /  出力ファイルの操作に関するクラス
    /  =============================================================*/
    class OutputFileControl
    {
        private string output_data_path;

        // 出力先のカレントディレクトリがあるか診断を行うクラス
        // 戻り値：(出力先フォルダが正しいとき)主力先フォルダのパス
        //         (それ以外)各出力に応じたエラーメッセージ
    }
    /* ==============================================================
    /  ファイルのコピーを行うクラス
    /  =============================================================*/
    class FileCopyControl
    {
        private string input_data_path;
        private string output_data_path;

        // ファイル名を代入する
        public void SetFileName(string in_path,string out_path)
        {
            input_data_path = in_path;
            output_data_path = out_path;
        }
        // ファイルのコピーを開始する
        public void FileCopyStart()
        {
            //フォルダのコピーを行う必要がある
            Copy(input_data_path, output_data_path);
        }
    }
}
