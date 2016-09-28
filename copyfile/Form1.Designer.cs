namespace copyfile
{
    partial class main_menu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.input_box = new System.Windows.Forms.TextBox();
            this.output_box = new System.Windows.Forms.TextBox();
            this.input_label = new System.Windows.Forms.Label();
            this.output_label = new System.Windows.Forms.Label();
            this.output_folder_choice = new System.Windows.Forms.Button();
            this.run_copy = new System.Windows.Forms.Button();
            this.close_this_soft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_box
            // 
            this.input_box.Enabled = false;
            this.input_box.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.input_box.Location = new System.Drawing.Point(13, 64);
            this.input_box.Name = "input_box";
            this.input_box.ReadOnly = true;
            this.input_box.Size = new System.Drawing.Size(752, 29);
            this.input_box.TabIndex = 0;
            // 
            // output_box
            // 
            this.output_box.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.output_box.Location = new System.Drawing.Point(13, 190);
            this.output_box.Name = "output_box";
            this.output_box.Size = new System.Drawing.Size(752, 29);
            this.output_box.TabIndex = 1;
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.input_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.input_label.Location = new System.Drawing.Point(12, 18);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(384, 43);
            this.input_label.TabIndex = 2;
            this.input_label.Text = "ONBUData(基データ)";
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.output_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.output_label.Location = new System.Drawing.Point(12, 144);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(463, 43);
            this.output_label.TabIndex = 3;
            this.output_label.Text = "バックアップデータの保存先";
            // 
            // output_folder_choice
            // 
            this.output_folder_choice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.output_folder_choice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.output_folder_choice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.output_folder_choice.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.output_folder_choice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.output_folder_choice.Location = new System.Drawing.Point(792, 183);
            this.output_folder_choice.Name = "output_folder_choice";
            this.output_folder_choice.Size = new System.Drawing.Size(185, 51);
            this.output_folder_choice.TabIndex = 4;
            this.output_folder_choice.Text = "参照";
            this.output_folder_choice.UseVisualStyleBackColor = false;
            // 
            // run_copy
            // 
            this.run_copy.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.run_copy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.run_copy.Location = new System.Drawing.Point(582, 285);
            this.run_copy.Name = "run_copy";
            this.run_copy.Size = new System.Drawing.Size(183, 51);
            this.run_copy.TabIndex = 5;
            this.run_copy.Text = "実行";
            this.run_copy.UseVisualStyleBackColor = true;
            // 
            // close_this_soft
            // 
            this.close_this_soft.Font = new System.Drawing.Font("MS UI Gothic", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.close_this_soft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.close_this_soft.Location = new System.Drawing.Point(792, 285);
            this.close_this_soft.Name = "close_this_soft";
            this.close_this_soft.Size = new System.Drawing.Size(185, 51);
            this.close_this_soft.TabIndex = 6;
            this.close_this_soft.Text = "閉じる";
            this.close_this_soft.UseVisualStyleBackColor = true;
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 358);
            this.Controls.Add(this.close_this_soft);
            this.Controls.Add(this.run_copy);
            this.Controls.Add(this.output_folder_choice);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.input_box);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "main_menu";
            this.Text = "ふぁいるコピー君";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_box;
        private System.Windows.Forms.TextBox output_box;
        public System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Label output_label;
        private System.Windows.Forms.Button output_folder_choice;
        private System.Windows.Forms.Button run_copy;
        private System.Windows.Forms.Button close_this_soft;
    }
}

