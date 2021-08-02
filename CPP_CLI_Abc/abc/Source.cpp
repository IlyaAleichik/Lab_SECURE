#include <iostream>
#include <string>

using namespace std;

void main(){
	string str="",key="";
	cout << "str\n";
	cin >> str;
	int stro, column,tmp=0;
	cout << "stroki,stolbi\n";
	cin >> stro >> column;
	string **mass = new string*[column];
	for (int i = 0; i < column; i++)
		mass[i] = new string[stro];
	string **mass2 = new string*[column];
	for (int i = 0; i < column; i++)
		mass2[i] = new string[stro];
	for(int i=0;i<column;i++)
		for (int j = 0; j < stro; j++) {
			mass[i][j] = str[tmp];
			tmp++;
		}
	for (int i = 0; i < stro; i++) {
		for (int j = 0; j < column; j++) {
			cout << mass[j][i];
		}
		cout << endl;
	}
	cout << "\nkey\n";
	cin >> key;
	tmp = 0;
	for (int i = 0; i < column; i++) {
		for (int j = 0; j < stro; j++) {
			if (i != int(key[i])-49)
				tmp = int(key[i]) - 49;
			mass2[i][j]= mass[tmp][j];
		}
	}
	cout << endl;
	for (int i = 0; i < stro; i++) {
		for (int j = 0; j < column; j++) {
			cout << mass2[j][i];
		}
		cout << endl;
	}
	system("pause");
}