using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace ChuKySoSchnorr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }

        // A simple method to evaluate
        // Euler Totient Function
        private int phi(int n)
        {
            int result = 1;
            for (int i = 2; i < n; i++)
                if (gcd(i, n) == 1)
                    result++;
            return result;
        }
        private List<int> PrimitiveRootCheck(int mod)
        {
            List<OrdInfo> orderList = getOrderList(mod);
            int fi = phi(mod);
            int pr = phi(fi);
            List<int> primitiveRoots = findPrimitiveRoots(orderList);

            return primitiveRoots;
        }
        private List<int> findPrimitiveRoots(List<OrdInfo> orderList)
        {
            List<int> primitiveRoots = new List<int>();
            foreach (OrdInfo n in orderList)
            {
                if (n.primitive)
                {
                    primitiveRoots.Add(n.x);
                }
            }

            return primitiveRoots;
        }
        private List<int> completeFactors(int n)
        {
            List<int> factors = new List<int>();
            int x = Math.Abs(n);

            for (var i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    factors.Add(i);
                }
            }
            return factors;
        }
        private int order(int a, int m)
        {
            int fi = phi(m);
            List<int> factors = completeFactors(fi);

            var answer = 0;
            BigInteger temp = 0;

            foreach (int i in factors)
            {

                temp = BigInteger.ModPow(a, i, m);

                if (temp == 1)
                {
                    answer = i;
                    return answer;
                }
            }
            return answer;
        }
        private List<OrdInfo> getOrderList(int mod)
        {
            List<OrdInfo> ordList = new List<OrdInfo>();
            int fi = phi(mod);
            int ord;
            for (int i = 1; i < mod; i++)
            {
                ord = order(i, mod);
                bool primitive;

                if (ord == fi)
                {
                    primitive = true;
                }
                else
                {
                    primitive = false;
                }
                ordList.Add(new OrdInfo(i, primitive));
            }
            return ordList;
        }

        private static string SHA256_String(string s)
        {
            var byteString = Encoding.UTF8.GetBytes("key");
            using (SHA256 sha256 = SHA256.Create())
            {
                StringBuilder hash = new StringBuilder();
                byte[] hashArray = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
                foreach (byte b in hashArray)
                {
                    hash.Append(b.ToString("x"));
                }
                return hash.ToString();
            }
        }

        public static BigInteger SHA256_Hex(string message)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                string hashHex = BitConverter.ToString(hashBytes).Replace("-", "").ToLower(); // Chuyển thành chuỗi hexa
                return BigInteger.Parse("0" + hashHex, System.Globalization.NumberStyles.HexNumber); // Chuyển thành BigInteger
            }
        }

        private List<int> findDivisor(int n)
        {
            List<int> array = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    array.Add(i);
                }
            }
            return array;
        }

        private bool validate(int p, int q, int g, int x)
        {
            // uoc cua p
            string divisor = "";
            divisor = String.Join(",", findDivisor(p - 1));
            List<int> divisor_list = findDivisor(p - 1);

            // nguyen thuy cua p
            string primitive = "";
            primitive = String.Join(", ", PrimitiveRootCheck(p));
            if (!divisor_list.Contains(q))
            {
                errorMsg.Text = "q phải là ước của " + (p - 1) + " gồm {" + divisor + "}";
                return false;
            }
            else if (!PrimitiveRootCheck(p).Contains(g))
            {
                errorMsg.Text = "g phải là nguyên thủy của " + (p) + " gồm {" + primitive + "}";
                return false;
            }
            else if (x < 0 || x > q - 1)
            {
                errorMsg.Text = "x phải khoảng [0, q-1]";
                return false;
            }
            txtY.Text = "";
            errorMsg.Text = "";
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = int.Parse(txtP.Text);
            int q = int.Parse(txtQ.Text);
            int g = int.Parse(txtG.Text);
            int x = int.Parse(txtX.Text);

            if (validate(p, q, g, x))
            {
                txtY.Text = Convert.ToString(Math.Pow(g, x) % p);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int p = int.Parse(txtP.Text);
            int g = int.Parse(txtG.Text);
            int q = int.Parse(txtP.Text);
            int x = int.Parse(txtX.Text);

            BigInteger hm = SHA256_Hex(txtMGenerate.Text);

            Random random = new Random();
            int k = random.Next((q - 1) - 2 + 1) + 2;
            if (txtP.Text != "")
            {
                txtKSign.Text = Convert.ToString(k);
            }
            BigInteger r = BigInteger.ModPow(g, x, p);
            txtRSign.Text = Convert.ToString(r);
            BigInteger s = (k - x * r * hm) % q;
            if (s < 0)
            {
                s += q;  // Điều chỉnh để đảm bảo s không âm
            }
            txtSSign.Text = Convert.ToString(s);
            txtSign.Text = "(" + r + ", " + s + ")";
            txtMCheck.Text = txtMGenerate.Text;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int p = int.Parse(txtP.Text);
            int r = int.Parse(txtRCheck.Text);
            int s = int.Parse(txtSCheck.Text);
            int q = int.Parse(txtQ.Text);
            int g = int.Parse(txtG.Text);
            int y = int.Parse(txtY.Text);
            int k = int.Parse(txtKSign.Text);
            int x = int.Parse(txtX.Text);

            BigInteger hm = SHA256_Hex(txtMGenerate.Text);
            BigInteger gs = (BigInteger.ModPow(g, s, p) * BigInteger.ModPow(y, hm, p)) % p;
            BigInteger ev = SHA256_Hex(gs.ToString());

            //BigInteger u1 = s;
            //BigInteger u2 = hm;

            //BigInteger gu1 = BigInteger.ModPow(g, u1, p);
            //BigInteger yu2 = BigInteger.ModPow(y, u2, p);

            //BigInteger v1 = (gu1 * yu2) % p;
            //BigInteger v2 = r % p;

            txtCheckResult.Text = "v1: " + ev + ", v2: " + hm;
            return;

            if (ev == hm)
            {
                txtCheckResult.Text = "Chữ ký hợp lệ :))";
            }
            else
            {
                txtCheckResult.Text = "Chữ ký giả mạo :))";
            }
        }
    }
}
