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

        //\dataを追記して値を返す
        // 戻り値：out_data + "\data"
        private string GetDataPath(string out_data)
        {
            return out_data + "\\data";
        }
        // 出力先のカレントディレクトリがあるか診断を行うクラス
        // 戻り値：(出力先フォルダが正しいとき)主力先フォルダのパス
        //         (それ以外)各出力に応じたエラーメッセージ
        public string SetDataPath(string out_data)
        {
            output_data_path = GetDataPath(out_data);

            if (!(System.IO.Directory.Exists(out_data)) || output_data_path == "\\data")
            {
                output_data_path = null;
            }

            return output_data_path;
        }
    }
    /* ==============================================================
    /  フォルダのコントロールを行うクラス
    /  =============================================================*/
    class FileCopyControl
    {
        /// <summary>
        /// ファルダコピーを開始する、例外処理などのエラー判定も行う
        /// </summary>
        /// <param name="input_data_path">コピーするディレクトリ</param>
        /// <param name="output_data_path">コピー先のディレクトリ</param> 
        public void FolderCopyStart(string input_data_path, string output_data_path)
        {
            if(output_data_path == null){
                //メッセージボックスを表示する
                ViewError("出力先のフォルダに存在しないフォルダが選択されています。");
            } else {
                CopyFolder(input_data_path, output_data_path);
                ViewMessage("完了");
            }
        }
        // エラーメッセージを表示する
        private void ViewError(string str)
        {
            MessageBox.Show(str,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        // 完了メッセージを表示する
        private void ViewMessage(string str)
        {
            MessageBox.Show(str,
                    "完了",
                    MessageBoxButtons.OK);
        }
        /// <summary>
        /// フォルダをコピーする
        /// </summary>
        /// <param name="input_data_path">コピーするディレクトリ</param>
        /// <param name="output_data_path">コピー先のディレクトリ</param> 
        private void CopyFolder(string input_data_path, string output_data_path)
        {
            // コピー先のフォルダがない場合は作る
            if (!System.IO.Directory.Exists(output_data_path))
            {
                System.IO.Directory.CreateDirectory(output_data_path);
                // 属性もコピー
                System.IO.File.SetAttributes(output_data_path,
                    System.IO.File.GetAttributes(input_data_path));
            }

            // コピー先のフォルダ名の末尾に\を付ける
            if (output_data_path[output_data_path.Length - 1] != System.IO.Path.DirectorySeparatorChar)
            {
                output_data_path = output_data_path + System.IO.Path.DirectorySeparatorChar;
            }
            // コピー元のフォルダにあるファイルをコピー
            string[] files = System.IO.Directory.GetFiles(input_data_path);
            foreach (string file in files)
            {
                System.IO.File.Copy(file, output_data_path + System.IO.Path.GetFileName(file), true);
            }
            //コピー元のフォルダにあるフォルダについて再帰的に呼び出す。
            string[] folders = System.IO.Directory.GetDirectories(input_data_path);
            foreach (string folder in folders)
            {
                CopyFolder(folder, output_data_path + System.IO.Path.GetFileName(folder));
            }
        }
    }
}
