using System; // �W�����C�u������System���C���|�[�g
using System.Collections.Generic; // �W�����C�u������System.Collections.Generic���C���|�[�g

class MainClass
{
    public static void Main(string[] args) // Main���\�b�h
    {
        int N, K; // �ϐ��̐錾
        string[] input = Console.ReadLine().Split(' '); // �W�����͂���l���擾���A�󔒂ŕ����������ʂ�z��Ɋi�[
        N = int.Parse(input[0]); // �z���1�Ԗڂ̗v�f��int�^�ɕϊ����ĕϐ�N�Ɋi�[
        K = int.Parse(input[1]); // �z���2�Ԗڂ̗v�f��int�^�ɕϊ����ĕϐ�K�Ɋi�[

        List<string> name = new List<string>(); // ���O���i�[���郊�X�g��錾
        Dictionary<string, List<KeyValuePair<string, int>>> receipt = new Dictionary<string, List<KeyValuePair<string, int>>>(); // ���V�[�g���i�[���鎫����錾

        for (int i = 0; i < N; i++) // N�񃋁[�v
        {
            name.Add(Console.ReadLine()); // �W�����͂��疼�O���擾���A���X�g�ɒǉ�
            receipt.Add(name[i], new List<KeyValuePair<string, int>>()); // �����ɖ��O���L�[�Ƃ��āA��̃��X�g��l�Ƃ��Ēǉ�
        }

        for (int i = 0; i < K; i++) // K�񃋁[�v
        {
            string[] data = Console.ReadLine().Split(' '); // �W�����͂���l���擾���A�󔒂ŕ����������ʂ�z��Ɋi�[
            string a = data[0]; // �z���1�Ԗڂ̗v�f��ϐ�a�Ɋi�[
            string p = data[1]; // �z���2�Ԗڂ̗v�f��ϐ�p�Ɋi�[
            int m = int.Parse(data[2]); // �z���3�Ԗڂ̗v�f��int�^�ɕϊ����ĕϐ�m�Ɋi�[
            receipt[a].Add(new KeyValuePair<string, int>(p, m)); // �����̃L�[��a�̃��X�g�ɁA���i���Ƌ��z���i�[����KeyValuePair��ǉ�
        }

        for (int i = 0; i < N; i++) // N�񃋁[�v
        {
            Console.WriteLine(name[i]); // ���O���o��
            foreach (KeyValuePair<string, int> pm in receipt[name[i]]) // ���O���L�[�Ƃ������X�g�̗v�f�����[�v�Ŏ��o��
            {
                Console.WriteLine(pm.Key + " " + pm.Value); // ���i���Ƌ��z���o��
            }
            Console.WriteLine("-----"); // ��؂�����o��
        }
    }
}
