using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region 質數特性
  /*
  1.最小的質數是2。
  2.除2以外的質數都是奇數。
  3.所有非質數都可做質因數分解。
  4.非質數的最大質因數不會大於他的平方根。
  */
#endregion

namespace Prime_Number_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TxtIn.Focus();
        }
        #region 變數
        bool isError;//用作判斷是否程式錯誤
        uint number;//儲存使用者輸入值
        uint maxValue;//儲存被判斷數值的平方根
        int sum;//儲存質數數量
        uint prime;
        #endregion
        private void BtnFind_Click(object sender, EventArgs e)
        {
            SetDefault();//設定預設值
            SetNumberToInput();//指定 number 為使用者輸入值
            if (isError) return;//輸入值錯誤就不做後續判斷
            if (number < 2)
            {
                TxtAnswer.Text = "請輸入2或2以上整數";
                return;
            }
            PrimeJudgment();//判斷哪個數值是質數
            TxtSum.Text = sum.ToString();
        }
        void SetDefault()//設定預設值
        {
            TxtAnswer.Text = "";
            //TxtAnswer.Text = "2";
            isError = false;
            sum = 1;
        }
        void SetNumberToInput()//指定 number 為使用者輸入值
        {
            try
            {
                number = Convert.ToUInt32(TxtIn.Text);
            }
            catch (FormatException ex)
            {
                TxtAnswer.Text = "格式轉換錯誤，請輸入整數數值資料";
                isError = true;
            }
            catch (OverflowException ex)
            {
                TxtAnswer.Text = "數值超出範圍，請輸入 0 ~ 4,294,967,295 之間整數值";
                isError = true;
            }
            catch (Exception ex)
            {
                TxtAnswer.Text = ex.Message; //這句輸出簡單的錯誤說明
                //TxtAnswer.Text = ex.ToString(); //這句輸出詳細的錯誤說明
                isError = true;
            }
        }
        void PrimeJudgment()//判斷哪個數值是質數
        {
            for (prime = 1; prime < number; prime += 2)
            {
                maxValue = (uint)Math.Sqrt(prime);
                int h = 1;
                while (h < prime)
                {
                    h++;
                    if (prime % h == 0)
                    {
                        break;
                    }
                    if (h > maxValue)
                    {
                        sum++;
                        //SavePrime();//儲存質數
                        //PrintPrime();//顯示質數列表
                        break;
                    }
                }
            }
        }
        void SavePrime()//儲存質數
        {
            
        }
        void PrintPrime()//顯示質數列表
        {
            TxtAnswer.Text += "、" + prime;
        }
    }
}
