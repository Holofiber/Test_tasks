namespace TicTacToe.WF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTurn = new System.Windows.Forms.TableLayoutPanel();
            this.tbX = new System.Windows.Forms.TextBox();
            this.BtnTurn = new System.Windows.Forms.Button();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tlpGameBoard = new System.Windows.Forms.TableLayoutPanel();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.tlpMainPanel.SuspendLayout();
            this.tlpTurn.SuspendLayout();
            this.tlpGameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainPanel
            // 
            this.tlpMainPanel.ColumnCount = 1;
            this.tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainPanel.Controls.Add(this.tlpTurn, 0, 1);
            this.tlpMainPanel.Controls.Add(this.tlpGameBoard, 0, 0);
            this.tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainPanel.Location = new System.Drawing.Point(0, 0);
            this.tlpMainPanel.Name = "tlpMainPanel";
            this.tlpMainPanel.RowCount = 2;
            this.tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMainPanel.Size = new System.Drawing.Size(338, 305);
            this.tlpMainPanel.TabIndex = 2;
            // 
            // tlpTurn
            // 
            this.tlpTurn.ColumnCount = 3;
            this.tlpTurn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTurn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTurn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTurn.Controls.Add(this.tbX, 1, 0);
            this.tlpTurn.Controls.Add(this.BtnTurn, 0, 0);
            this.tlpTurn.Controls.Add(this.tbY, 2, 0);
            this.tlpTurn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTurn.Location = new System.Drawing.Point(3, 276);
            this.tlpTurn.Name = "tlpTurn";
            this.tlpTurn.RowCount = 1;
            this.tlpTurn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTurn.Size = new System.Drawing.Size(332, 26);
            this.tlpTurn.TabIndex = 2;
            // 
            // tbX
            // 
            this.tbX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbX.Location = new System.Drawing.Point(113, 3);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(104, 20);
            this.tbX.TabIndex = 0;
            // 
            // BtnTurn
            // 
            this.BtnTurn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTurn.Location = new System.Drawing.Point(3, 3);
            this.BtnTurn.Name = "BtnTurn";
            this.BtnTurn.Size = new System.Drawing.Size(104, 20);
            this.BtnTurn.TabIndex = 2;
            this.BtnTurn.Text = "Turn";
            this.BtnTurn.UseVisualStyleBackColor = true;
            this.BtnTurn.Click += new System.EventHandler(this.BtnTurn_Click);
            // 
            // tbY
            // 
            this.tbY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbY.Location = new System.Drawing.Point(223, 3);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(106, 20);
            this.tbY.TabIndex = 1;
            // 
            // tlpGameBoard
            // 
            this.tlpGameBoard.ColumnCount = 3;
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpGameBoard.Controls.Add(this.btn22, 2, 2);
            this.tlpGameBoard.Controls.Add(this.btn21, 1, 2);
            this.tlpGameBoard.Controls.Add(this.btn20, 0, 2);
            this.tlpGameBoard.Controls.Add(this.btn11, 1, 1);
            this.tlpGameBoard.Controls.Add(this.btn10, 0, 1);
            this.tlpGameBoard.Controls.Add(this.btn02, 2, 0);
            this.tlpGameBoard.Controls.Add(this.btn01, 1, 0);
            this.tlpGameBoard.Controls.Add(this.btn00, 0, 0);
            this.tlpGameBoard.Controls.Add(this.btn12, 2, 1);
            this.tlpGameBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGameBoard.Location = new System.Drawing.Point(3, 3);
            this.tlpGameBoard.Name = "tlpGameBoard";
            this.tlpGameBoard.RowCount = 3;
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGameBoard.Size = new System.Drawing.Size(332, 267);
            this.tlpGameBoard.TabIndex = 1;
            // 
            // btn22
            // 
            this.btn22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn22.Enabled = false;
            this.btn22.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Location = new System.Drawing.Point(223, 181);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(106, 83);
            this.btn22.TabIndex = 8;
            this.btn22.Text = "X";
            this.btn22.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn21.Enabled = false;
            this.btn21.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Location = new System.Drawing.Point(113, 181);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(104, 83);
            this.btn21.TabIndex = 7;
            this.btn21.Text = "X";
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn20.Enabled = false;
            this.btn20.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(3, 181);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(104, 83);
            this.btn20.TabIndex = 6;
            this.btn20.Text = "X";
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn11.Enabled = false;
            this.btn11.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(113, 92);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(104, 83);
            this.btn11.TabIndex = 4;
            this.btn11.Text = "X";
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn10.Enabled = false;
            this.btn10.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(3, 92);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(104, 83);
            this.btn10.TabIndex = 3;
            this.btn10.Text = "X";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            this.btn02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn02.Enabled = false;
            this.btn02.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.Location = new System.Drawing.Point(223, 3);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(106, 83);
            this.btn02.TabIndex = 2;
            this.btn02.Text = "X";
            this.btn02.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            this.btn01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn01.Enabled = false;
            this.btn01.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.Location = new System.Drawing.Point(113, 3);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(104, 83);
            this.btn01.TabIndex = 1;
            this.btn01.Text = "X";
            this.btn01.UseVisualStyleBackColor = true;
            // 
            // btn00
            // 
            this.btn00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn00.Enabled = false;
            this.btn00.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(3, 3);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(104, 83);
            this.btn00.TabIndex = 0;
            this.btn00.Text = "X";
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn12.Enabled = false;
            this.btn12.Font = new System.Drawing.Font("Wide Latin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(223, 92);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(106, 83);
            this.btn12.TabIndex = 5;
            this.btn12.Text = "X";
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 305);
            this.Controls.Add(this.tlpMainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tlpMainPanel.ResumeLayout(false);
            this.tlpTurn.ResumeLayout(false);
            this.tlpTurn.PerformLayout();
            this.tlpGameBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainPanel;
        private System.Windows.Forms.TableLayoutPanel tlpTurn;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TableLayoutPanel tlpGameBoard;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn12;
        internal System.Windows.Forms.Button BtnTurn;
    }
}

