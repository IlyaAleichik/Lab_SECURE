#include "stdafx.h"
#include "ProgClass.h"
#include <iostream>
using namespace std;




void C_Menu::m_Text() {

	cout << "�������� ����� ���������� !" << "\n \n" 
		<< "1. ����� ��������� ������ " << "\n"
		<< "2. ���������� ������� " << "\n"
		<< "3. �������� " << "\n"
		<< "4. ������ " << "\n"
		<< "5. ������� " << "\n"
		<< "6. ������� ������� ������� " << "\n"
		<< "7. ���� �������� " << "\n"
		<< "8. ���� ������� " << "\n";
}

void C_Menu::m_Menu() {
	system("cls");


	C_Shifri shifr;
	
	m_Text();
	int num;
	cin >> num;
	switch (num)
	{
	case 1:
		system("cls");
		shifr.Shifr_Table();
		break;

	case 2:
		system("cls");
		shifr.Shifr_MagicSquare();
		break;

	case 3:
		system("cls");
		shifr.Shifr_Trisemus();
		break;

	case 4:
		system("cls");
		shifr.Shifr_Cesar();
		break;
		
	case 5:
		system("cls");
		shifr.Shifr_Plefer();;
		break;

	case 6:
		system("cls");
	   shifr.Shifr_Witsona();
		break;

	case 7:
		system("cls");
	    shifr.Shifr_Vigenera();
		break;

	case 8:
		system("cls");
		shifr.Shifr_Vernama();
		break;
	}
}