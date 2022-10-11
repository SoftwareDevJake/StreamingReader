using UnityEngine;

public class StreamingReader : MonoBehaviour
{
    int m_iLineNum = 0;
    string m_sFileName = "Settings";

    private void Awake()
    {
        ReadString();
    }

    void ReadString()
    {
        System.IO.StreamReader _reader = new System.IO.StreamReader(Application.dataPath + "/StreamingAssets" + "/" + m_sFileName + ".txt");

        while (!_reader.EndOfStream)
        {
            if (m_iLineNum == 1)
            {
                Strings.IP = _reader.ReadLine();
                Debug.Log("ip : " + Strings.IP);
            }
            else if (m_iLineNum == 3)
            {
                Strings.PORT = int.Parse(_reader.ReadLine());
                Debug.Log("port : " + Strings.PORT);
            }
            else
            {
                Debug.LogWarning("UNDIFINED DATA   :   " + _reader.ReadLine());
            }
            m_iLineNum++;
        }
        _reader.Close();

    }
}