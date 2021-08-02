#pragma once
#include <time.h>


using namespace std;
C_Menu menu;

string keygen(int len)
{
	string key;

	key.resize(len);
	srand(time(NULL));

	for (int i = 0; i < len; i++) {
		key[i] = (char)rand();
	}
	return key;
}

string Vernam_encry(int len, string opeTxT, string key)
{
	string cipTxT; 

	cipTxT.resize(len);

	
	for (int i = 0; i < len; i++)

		cipTxT[i] = opeTxT[i] ^ key[i]; 

									 
	cout << "���������� :\n\n �������� �����: " << opeTxT << endl;
	cout << "\n ����: " << key << endl;
	cout << "\n ������������ �����: " << cipTxT << endl;
	cout << endl;
	return cipTxT;
}

string Vernam_decry(int len, string cipTxT, string key)
{
	string opeTxT; 

	key.resize(len);
	cipTxT.resize(len);
	opeTxT.resize(len);

	
	for (int i = 0; i < len; i++)

		opeTxT[i] = cipTxT[i] ^ key[i]; 

									   
	cout << "����������: \n\n ������������ �����:" << cipTxT << endl;
	cout << "\n ����: " << key << endl;
	cout << "\n �������� �����: " << opeTxT << endl;
	cout << endl;
	return opeTxT;
}

void findXY(char * aTable, char aCh, int& aX, int& aY) {
	for (int y = 0; y < 7; y++) {
		for (int x = 0; x < 5; x++) {
			if (aTable[y * 5 + x] == aCh) {
				aX = x;
				aY = y;
				return;
			}
		}
	}

	// ��� ������ �������
	aX = -1;
	aY = -1;
}
 
void f_exit() {
	char a;
	cout<< "\n\n";
	cout << "/////////////////////////////////////////////////////////////////////////////// " << "\n";
	cout << "//          y . ��������� � ���� /  n. ��������� ������ ���������  y/n       // " << "\n";
	cout << "/////////////////////////////////////////////////////////////////////////////// " << "\n";
	cout << ">>"; cin >> a;
	
	
	if (a == 'y') {
		menu.m_Menu();
	}
	


}