// 002.cpp : Defines the entry point for the console application.
// 

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	
	long lastNumber = 1;
	long currentNumber = 2;
	long long sum = 0; 
	while(currentNumber<4000000)
	{
		if(currentNumber%2==0)
		{
			sum+=currentNumber;
		}
		currentNumber+=lastNumber;
		lastNumber = currentNumber-lastNumber;

		printf("%d \n", currentNumber);
	}
	printf("The sum is: %d\n", sum);
	return 0;
}

