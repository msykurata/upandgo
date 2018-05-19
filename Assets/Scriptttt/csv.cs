using UnityEngine;
using System.Text;
using System.IO;
using UnityEngine.UI;

public class csv : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        /*
        // ファイル書き出し
        // 現在のフォルダにsaveData.csvを出力する(決まった場所に出力したい場合は絶対パスを指定してください)
        // 引数説明：第1引数→ファイル出力先, 第2引数→ファイルに追記(true)or上書き(false), 第3引数→エンコード
        StreamWriter sw = new StreamWriter(@"saveData.csv", false, Encoding.GetEncoding("Shift_JIS"));
        // ヘッダー出力
        string[] s1 = { "time", "x","y","z" };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);

        sw.Close();
        

        // ファイル読み込み
        // 引数説明：第1引数→ファイル読込先, 第2引数→エンコード
        StreamReader sr = new StreamReader(@"saveData.csv", Encoding.GetEncoding("Shift_JIS"));
        string line;
        // 行がnullじゃない間(つまり次の行がある場合は)、処理をする
        while ((line = sr.ReadLine()) != null)
        {
            // コンソールに出力
            Debug.Log(line);
        }
        // StreamReaderを閉じる
        sr.Close();
        */
        onetimepos = transform.position;
        time1 = 0;
        GameObject.Find("CSVStop").GetComponent<Button>().interactable = false;
    }

    private Vector3 onetimepos;
    private float time1;
    public static bool saves;
    private double savetime;
    // Update is called once per frame
    void Update()
    {

        //Debug.Log(GameObject.Find("InputField").GetComponent<InputField>().text);

        if (saves)
        {
            
            if (savetime > 0.1)
            {
                onetimepos = transform.position;
                //StreamWriter sw = new StreamWriter(DataName, true, Encoding.GetEncoding("Shift_JIS"));
                StreamWriter sw = new StreamWriter(DataName, true, Encoding.GetEncoding("Shift_JIS"));
                string[] onepos = { time1.ToString(), onetimepos.x.ToString(), onetimepos.y.ToString(), onetimepos.z.ToString() };
                string poslog = string.Join(",", onepos);
                sw.WriteLine(poslog);
                sw.Flush();
                sw.Close();
                //onetimepos = GameObject.Find("Cube").transform.position;
                //poslog ={ onetimepos.x.ToString() , onetimepos.y.ToString() , onetimepos.z.ToString() };
                //s2 = string.Join(",", poslog);
                savetime = 0;
            }
            time1 += Time.deltaTime;
            savetime += Time.deltaTime;
        }
       
    }
    private string DataName;
    byte filenum_1 = 0;
    byte filenum_10 = 0;
    byte filenum_100 = 0;

    public void RecStart()
    {
        if (!saves)
        {
            saves = true;
            GameObject.Find("CSVStart").GetComponent<Button>().interactable = false;
            GameObject.Find("CSVStop").GetComponent<Button>().interactable = true;

            DataName = GameObject.Find("InputField").GetComponent<InputField>().text + "000.csv";
            while (true)
            {
                if (File.Exists(DataName))
                {
                    filenum_1++;
                    if (filenum_1 > 9)
                    {
                        filenum_10++;
                        filenum_1 = 0;
                        if (filenum_10 > 9)
                        {
                            filenum_100++;
                            filenum_10 = 0;
                        }
                    }
                    DataName = GameObject.Find("InputField").GetComponent<InputField>().text;
                    DataName += filenum_100;
                    DataName += filenum_10;
                    DataName += filenum_1;
                    DataName += ".csv";
                }
                else
                {
                    break;
                }
            }
            StreamWriter sw = new StreamWriter(DataName, false, Encoding.GetEncoding("Shift_JIS"));
            // ヘッダー出力
            string[] s1 = { "time", "x", "y", "z" };
            string s2 = string.Join(",", s1);
            sw.WriteLine(s2);

            sw.Close();
        }
        else
        {
            saves = false;
            GameObject.Find("CSVStart").GetComponent<Button>().interactable = true;
            GameObject.Find("CSVStop").GetComponent<Button>().interactable = false;
        }   
    }
}