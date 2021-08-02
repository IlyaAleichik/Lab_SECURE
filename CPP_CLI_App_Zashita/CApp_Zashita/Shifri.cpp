#include "stdafx.h"
#include "ProgClass.h"
#include <iostream>
#include <Windows.h>
#include <string>
#include "functons.h"

using namespace std;
void C_Shifri::Shifr_Table() {

	  system("cls");

		string str = "", key = "";
		cout << "str\n";
		cin >> str;
		int stro, column, tmp = 0;
		cout << "Кол-во строк, Кол-во столбцов\n";
		cin >> stro >> column;
		string **mass = new string*[column];
		for (int i = 0; i < column; i++)
			mass[i] = new string[stro];
		string **mass2 = new string*[column];
		for (int i = 0; i < column; i++)
			mass2[i] = new string[stro];
		for (int i = 0; i<stro; i++)
			for (int j = 0; j < column; j++) {
				cin >> tmp;
				mass[j][i] = str[tmp - 1];
			}
		for (int i = 0; i < stro; i++) {
			for (int j = 0; j < column; j++) {
				cout << mass[j][i];
			}
			cout << endl;
		//
		cout << endl;
		for (int i = 0; i < stro; i++) {
			for (int j = 0; j < column; j++) {
				cout << mass[j][i];
			}

		}

	}

	f_exit();

	
	

}
void C_Shifri::Shifr_Plefer() {
	system("cls");
	system("Plefer.exe");
	f_exit();
}
void C_Shifri::Shifr_MagicSquare() {
	system("cls");
	system("MagicSquare.exe");
	f_exit();
}
void C_Shifri::Shifr_Witsona(){
	system("cls");
	system("DoubleSquare.exe");
	f_exit();
}
void C_Shifri::Shifr_Trisemus() {
	system("cls");
	system("Trisemus.exe");
	f_exit();
}
void C_Shifri::Shifr_Cesar() {
	system("cls");
	system("Cesar.exe");
	f_exit();
}
void C_Shifri::Shifr_Vigenera() {
	system("cls");
	system("Vigener.exe");
	f_exit();
}
void C_Shifri::Shifr_Vernama() {
	
	int len = 0;
	string cipherTxT, plTxt, key, new_opeTxT;

	cout << "Шифр Вернама \n Введите текст для зашифровки: ";
	cin >> plTxt;

	len = plTxt.length();
	key = keygen(len);

	cipherTxT = Vernam_encry(len, plTxt, key); 
	new_opeTxT = Vernam_decry(len, cipherTxT, key); 

	f_exit();
	
}

