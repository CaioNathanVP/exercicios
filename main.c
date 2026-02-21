/******************************************************************************

Welcome to GDB Online.
  GDB online is an online compiler and debugger tool for C, C++, Python, PHP, Ruby, 
  C#, OCaml, VB, Perl, Swift, Prolog, Javascript, Pascal, COBOL, HTML, CSS, JS
  Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
#include <stdio.h>


void trocarvalores(int *a, int *b){
    int a1 = *a;
    int b1 = *b;
    *b = a1;
    *a = b1;
}

void main()
{
    int inteiro1 = 1;
    int inteiro2 = 2;

    printf("valor inicial - valor de a: %d  valor de b: %d  \n", inteiro1, inteiro2);
    trocarvalores(&inteiro1, &inteiro2);
    printf("valor trocado: - valor de a: %d  valor de b: %d ", inteiro1, inteiro2);
    
}