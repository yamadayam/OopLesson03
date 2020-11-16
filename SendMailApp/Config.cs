using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SendMailApp {
    public class Config {
        //単一のインスタンス
        private static Config instance;
        //インスタンスの取得
        public static Config GetInstace() {
            if (instance == null) {
                instance = new Config();
            }
            return instance;
        }

        public string Smtp { get; set; }//SMTPサーバ
        public string MailAddress{ get; set; }//自メールアドレス
        public string PassWord { get; set; }//パスワード
        public int Port{ get; set; }    //ポート番号
        public bool Ssl { get; set; }   //SSL設定
        
        //コンストラクタ(外部からnewできないようにする)
        private Config() {

        }

        //初期設定用
        public void DefaultSet() {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            Port = 587;
            Ssl = true;
        }

        //初期値取得用
        public Config getDefaultStatus() {
            Config obj = new Config() {
                Smtp = "smtp.gmail.com",
                MailAddress = "ojsinfosys01@gmail.com",
                PassWord = "ojsInfosys2020",
                Port = 587,
                Ssl = true
            };
            return obj;
        }

        //設定データ更新
        public bool UpdateStatus(string smtp,string mailAddress,string passWord,int port,bool ssl) {
            Smtp = smtp;
            MailAddress = mailAddress;
            PassWord = passWord;
            Port = port;            
            Ssl = ssl;
            return true;
        }

        //シリアル化 P305
        public void Serialise() {
            using (var writer = XmlWriter.Create(new StreamWriter("config.xml"))) {
                var serializer = new XmlSerializer(instance.GetType());
                serializer.Serialize(writer, instance);
            }
        }
        //逆シリアル化 P307
        public void DeSerialise() {
            using (var reader = XmlReader.Create(new StreamReader("config.xml"))) {
                var serializer = new XmlSerializer(typeof(Config));
                instance = serializer.Deserialize(reader) as Config;
            }
            
        }
    }
}
