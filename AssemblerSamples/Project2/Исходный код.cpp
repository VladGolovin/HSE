#include <iostream>
#include <string>
#include <stdio.h>
using namespace std;

int main()
{

	static int A, B, C[10];
//	cout << endl << "Time to choose: ";
//	cin >> choice;

		__asm
		{
			xor EAX, EAX //обнулить регистр
			mov ECX, 10 // засылаем в регистр счётчик размерность массива
			mov ESI, 0
		S: cmp C[ESI*4], 0
			jne L // jump on not equal. O - overflow(JO), Z - zero(JZ)
			inc EAX 
		L:	add ESI, 1 // (inc ESI)
			loop S
		}

	system("pause");
	return 0;
}


