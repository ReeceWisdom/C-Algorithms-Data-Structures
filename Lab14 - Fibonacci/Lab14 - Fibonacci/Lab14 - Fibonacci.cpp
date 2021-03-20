// Lab14 - Fibonacci.cpp : This file contains the 'main' function. Program execution begins and ends there.

#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	/*
	cout << "Hello World!\n" << endl;

	int myvar = 5;
	char course[10] = "SE5301";
	cout << course << " is a " << myvar << "* Course\n" << endl;

	int age;
	cout << "Please Enter Your Age > ";
	cin >> age;
	if (age < 18)
	{
		cout << "Being " << age;
		cout << " Years Old You Are Too Young To Vote" << endl;
	}
	else
	{
		cout << "You Are Old Enough To Vote" << endl;
	}
	cout << "Thank You For Using Vote-O-Matic\n" << endl;

	char name[20];
	cout << "Please Enter Your Name > ";
	cin >> name;
	cout << "Hello " << name << ", How Are You?\n" << endl;

	int num;
	cout << "Please Enter a Number > ";
	cin >> num;
	//for (int i = 1; i < num + 1; i++)
	int i = 1;  while (i != num + 1)
	{
		cout << i << endl;
		i++;
	}
	cout << "\n";

	for (int i = 2; i < 100; i++)
	{
		bool flag = true;
		for (int j = 2; j <= i / 2; j++)
		{
			if (i%j == 0)
			{
				flag = false;
				break;
			}
		}
		if (flag == true)
			cout << i << endl;
	}
	cout << "\n";

	cout << "Please Enter a Number > ";
	cin >> num;
	if (num % 2 == 0)
		cout << num << " is Even." << endl;
	else
		cout << num << " is Odd." << endl;
	*/

	int num1 = 0;
	int num2 = 1;
	int num3;
	int count;

	cout << "Please Enter a Number > ";
	cin >> count;
	cout << "Fibonacci Sequence: " << num1 << " - " << num2 << " - ";
	num3 = num1 + num2;

	for (int i = 0; i < count - 2; i++)
	{
		cout << num3 << " - ";
		num1 = num2;
		num2 = num3;
		num3 = num1 + num2;
	}
	cout << "Ended\n";

	int num4 = 0;
	int num5 = 1;
	int num6;
	
	cout << "Please Enter a Number > ";
	cin >> count;
	cout << "Fibonacci Sequence: " << num4 << " - " << num5 << " - ";
	num6 = num4 + num5;

	while (num6 <= count)
	{
		cout << num6 << " - ";
		num4 = num5;
		num5 = num6;
		num6 = num4 + num5;
	}
	cout << "Ended\n";
}
