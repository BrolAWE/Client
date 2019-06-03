using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient
{
    class ArithmeticC
    {
        sbyte zero = (sbyte)Convert.ToInt32('0');
        sbyte[] op1, op2;
        sbyte[] r1, r2;
        sbyte rT;

        public bool ConvOps(string _op1, string _op2)
        {
            byte zero = Convert.ToByte('0');
            bool res1, res2;
            int i;
            if (_op1.Length > _op2.Length)
            {
                op1 = new sbyte[_op1.Length];
                op2 = new sbyte[_op1.Length];
            }
            else
            {
                op1 = new sbyte[_op2.Length];
                op2 = new sbyte[_op2.Length];
            }
            for (i = 0; i < op1.Length; i++)
            {
                op1[i] = 0;
                op2[i] = 0;
            }
            i = 0;
            res1 = true;
            while (i < _op1.Length & res1)
            {
                if (_op1[i] >= '0' & _op1[i] <= '9')
                    op1[i] = (sbyte)(Convert.ToInt32(_op1[_op1.Length - 1 - i]) - zero);
                else
                    res1 = false;
                i++;
            }
            i = 0;
            res2 = true;
            while (i < _op2.Length & res2)
            {
                if (_op2[i] >= '0' & _op2[i] <= '9')
                    op2[i] = (sbyte)(Convert.ToByte(_op2[_op2.Length - 1 - i]) - zero);
                else
                    res2 = false;
                i++;
            }
            return res1 & res2;
        }

        public string Show()
        {
            int i;
            string res;
            res = "";
            for (i = 0; i < r1.Length; i++)
            {
                res = r1[i].ToString() + res;
            }
            return res;
        }

        public void LAdd()
        {
            r1 = new sbyte[op1.Length];
            r2 = new sbyte[op2.Length];
            rT = 0;
            r1 = op1;
            Array.Resize(ref r1, r1.Length + 1);
            r1[r1.Length - 1] = 0;
            r2 = op2;
            RAdd();
        }

        public void RAdd()
        {
            int i;
            sbyte dSum;
            rT = 0;
            for (i = 0; i < r2.Length; i++)
            {
                dSum = (sbyte)(r1[i] + r2[i] + rT);
                r1[i] = (sbyte)(dSum % 10);
                rT = (sbyte)(dSum / 10);
            }
            r1[r1.Length - 1] = rT;
        }

        public void LSub()
        {
            int i;
            r1 = new sbyte[op1.Length];
            r2 = new sbyte[op2.Length];
            rT = 0;
            r1 = op1;
            Array.Resize(ref r1, r1.Length + 1);
            r1[r1.Length - 1] = 0;
            r2 = op2;
            if (r2[0] > 0)
                r2[0] = (sbyte)(10 - r2[0]);
            for (i = 1; i < r2.Length; i++)
                r2[i] = (sbyte)(9 - r2[i]);
            LAdd();
            r1[r1.Length - 1] = 0;
        }

        public void LMult()
        {
            int i, j;
            sbyte dMult;
            r1 = new sbyte[op1.Length * 2];
            r2 = new sbyte[op2.Length * 2];
            for (i = 0; i < r1.Length; i++)
                r1[i] = 0;
            for (i = 0; i < r2.Length; i++)
                r2[i] = 0;
            for (i = 0; i < op2.Length; i++)
            {
                rT = 0;
                //Array.Resize(ref r2, r2.Length + 1);
                for (j = 0; j < i; j++)
                    r2[j] = 0;
                for (j = 0; j < op1.Length; j++)
                {
                    dMult = (sbyte)(op1[j] * op2[i] + rT);
                    r2[j + i] = (sbyte)(dMult % 10);
                    rT = (sbyte)(dMult / 10);
                }
                r2[j + i] = rT;
                //Array.Resize(ref r1, r1.Length + 1);
                RAdd();
            }
        }
    }
}
