#include<iostream>
using namespace std;

void printQ1(int number){
    string tempRow = "";
    for(int j = -number + 1; j < number; j++){
        tempRow = "";
        for(int i = -number + 1; i < number; i++){
            if(((i >= -j && -i >= -j) || (i >= j && -i >= j)) && (((i - j) % 2) == 0)){
                tempRow += "X";
            }else{
                tempRow += "O";
            }
        }
        cout<<tempRow<<endl;
    }
}

void printQ2(int number){
    string tempRow = "";
    for(int j = 0; j < number; j++){
        tempRow = "";
        for(int i = 0; i < number; i++){
            if((i >= j && (i >= number - 1 - j)) || ((number - 1 - i >= j) && (-i >= -j))){
                tempRow += "X";
            }else{
                tempRow += " ";
            }
        }
        cout<<tempRow<<endl;
    }
}

int main (void) {

    int number=0;
    cin>>number;

    // printQ1(number);
    printQ1(number);
}
