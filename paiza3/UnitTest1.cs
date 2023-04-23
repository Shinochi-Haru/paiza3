using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // �t�|�[�����h�L�@�̎������
        string input = Console.ReadLine();

        // �X�^�b�N��p��
        var stack = new Stack<int>();

        // ���͂��ꂽ�����X�y�[�X�ŕ������Ĕz��ɕϊ�
        string[] tokens = input.Split(' ');

        foreach (string token in tokens)
        {
            int num;
            if (int.TryParse(token, out num))
            {
                // �g�[�N�������l�̏ꍇ�̓X�^�b�N�ɐς�
                stack.Push(num);
            }
            else
            {
                // �g�[�N�������Z�q�̏ꍇ�̓X�^�b�N����2���o���Čv�Z
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();

                switch (token)
                {
                    case "+":
                        stack.Push(operand1 + operand2);
                        break;
                    case "-":
                        stack.Push(operand1 - operand2);
                        break;
                    case "*":
                        stack.Push(operand1 * operand2);
                        break;
                    case "/":
                        stack.Push(operand1 / operand2);
                        break;
                    default:
                        Console.WriteLine("�s���ȉ��Z�q�ł��B");
                        return;
                }
            }
        }

        // �v�Z���ʂ��o��
        Console.WriteLine("�v�Z���ʂ� {0} �ł��B", stack.Pop());
    }
}
