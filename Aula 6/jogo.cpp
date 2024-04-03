#include <iostream>
#include <random>

using namespace std;

int main() {
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAleatorio);

    int numdig;
    int contador = 0;

    cout << "Adivinhe o número entre 1 e 100!"<<endl;

    do {
        
    cout << "Digite um número entre 1 e 100: "<<endl;
    cin >> numdig;
    contador++;

    if (numdig < valorInteiro) 
        {
            cout << "Chutou baixo!"<<endl;
        } 
    else if (numdig > valorInteiro) 
        {
            cout << "Chutou alto!"<<endl;
        } 
    else 
        {
            cout << "Parabéns! Você acertou o número " << valorInteiro << " em " << contador << " tentativas."<<endl;
        }

    } while (numdig != valorInteiro);

    return 0;
}


