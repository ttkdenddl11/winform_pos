
namespace _45_DB_1_POS_Build
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgViewSale = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numItem = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxSum = new System.Windows.Forms.TextBox();
            this.btnSaleState = new System.Windows.Forms.Button();
            this.btnInven = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(668, 327);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "상품 판매";
            // 
            // dgViewSale
            // 
            this.dgViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewSale.Location = new System.Drawing.Point(51, 74);
            this.dgViewSale.Name = "dgViewSale";
            this.dgViewSale.RowTemplate.Height = 23;
            this.dgViewSale.Size = new System.Drawing.Size(582, 345);
            this.dgViewSale.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(668, 362);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "담기";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(668, 396);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(114, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "계산하기";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(665, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "상품명";
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(668, 93);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(114, 21);
            this.tboxName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(665, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "가격";
            // 
            // tboxPrice
            // 
            this.tboxPrice.Location = new System.Drawing.Point(668, 153);
            this.tboxPrice.Name = "tboxPrice";
            this.tboxPrice.Size = new System.Drawing.Size(114, 21);
            this.tboxPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(665, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "개수";
            // 
            // numItem
            // 
            this.numItem.Location = new System.Drawing.Point(668, 207);
            this.numItem.Name = "numItem";
            this.numItem.Size = new System.Drawing.Size(120, 21);
            this.numItem.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(665, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "합계";
            // 
            // tboxSum
            // 
            this.tboxSum.Location = new System.Drawing.Point(668, 262);
            this.tboxSum.Name = "tboxSum";
            this.tboxSum.Size = new System.Drawing.Size(114, 21);
            this.tboxSum.TabIndex = 12;
            // 
            // btnSaleState
            // 
            this.btnSaleState.Location = new System.Drawing.Point(51, 441);
            this.btnSaleState.Name = "btnSaleState";
            this.btnSaleState.Size = new System.Drawing.Size(114, 23);
            this.btnSaleState.TabIndex = 13;
            this.btnSaleState.Text = "판매 내역";
            this.btnSaleState.UseVisualStyleBackColor = true;
            // 
            // btnInven
            // 
            this.btnInven.Location = new System.Drawing.Point(171, 441);
            this.btnInven.Name = "btnInven";
            this.btnInven.Size = new System.Drawing.Size(114, 23);
            this.btnInven.TabIndex = 14;
            this.btnInven.Text = "재고 현황";
            this.btnInven.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatus.Location = new System.Drawing.Point(736, 467);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 489);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnInven);
            this.Controls.Add(this.btnSaleState);
            this.Controls.Add(this.tboxSum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgViewSale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgViewSale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxSum;
        private System.Windows.Forms.Button btnSaleState;
        private System.Windows.Forms.Button btnInven;
        private System.Windows.Forms.Label lblStatus;
    }
}

