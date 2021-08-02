#include "stdafx.h"
#include "ProgClass.h"
#include <iostream>
using namespace std;




void C_Menu::m_Text() {

	cout << "Выберите метод шифрования !" << "\n \n" 
		<< "1. Метод шифрующик таблиц " << "\n"
		<< "2. Магический квадрат " << "\n"
		<< "3. Трисемус " << "\n"
		<< "4. Цезарь " << "\n"
		<< "5. Плейфер " << "\n"
		<< "6. Двойной квадрат Уитсона " << "\n"
		<< "7. Шивр Виженера " << "\n"
		<< "8. Шивр Вернама " << "\n";
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