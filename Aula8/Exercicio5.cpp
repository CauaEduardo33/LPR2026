#include <iostream>
#include <string>
#include <vector>

#define MAX_CHAMADOS 10

using namespace std;

struct Chamado
{
    int numero;
    string solicitante;
    string setor;
    int prioridade;
    string status;
    string descricao;
};

vector<Chamado> chamados;

void cadastrarChamado() {
    if (chamados.size() < MAX_CHAMADOS) {
        Chamado chamado;
        chamado.numero = chamados.size() + 1;

        cout << "Solicitante: ";
        cin >> chamado.solicitante;

        cout << "Setor: ";
        cin >> chamado.setor;

        cout << "Prioridade (1-Baixa, 2-Media, 3-Alta): ";
        cin >> chamado.prioridade;

        chamado.status = "Aberto";

        cout << "Descricao: ";
        cin.ignore();
        getline(cin, chamado.descricao);

        chamados.push_back(chamado);

        cout << "Chamado cadastrado com sucesso!\n";
    }
    else {
        cout << "O numero maximo de chamados foi atingido.\n";
    }
}

void listarChamados() {
    if (chamados.empty()) {
        cout << "Nenhum chamado cadastrado.\n";
        return;
    }

    for (Chamado chamado : chamados) {
        cout << "\nNumero: " << chamado.numero
             << "\nSolicitante: " << chamado.solicitante
             << "\nSetor: " << chamado.setor
             << "\nPrioridade: " << chamado.prioridade
             << "\nStatus: " << chamado.status
             << "\nDescricao: " << chamado.descricao
             << "\n";
    }
}

void atualizarStatus() {
    cout << "Insira o numero do chamado a ser atualizado: ";

    int escolha;
    cin >> escolha;

    if (escolha < 1 || escolha > chamados.size()) {
        cout << "Nao existe chamado com esse numero.\n";
        return;
    }

    cout << "Novo status (Aberto, Em andamento, Resolvido, Cancelado): ";
    cin.ignore();

    string aux_novo_status;
    getline(cin, aux_novo_status);

    if (aux_novo_status != "Resolvido" &&
        aux_novo_status != "Aberto" &&
        aux_novo_status != "Em andamento" &&
        aux_novo_status != "Cancelado") {

        cout << "Status invalido.\n";
        return;
    }

    chamados[escolha - 1].status = aux_novo_status;

    cout << "Status atualizado com sucesso!\n";
}

void classificarPrioridade(Chamado chamado) {
    switch (chamado.prioridade) {
        case 1:
            cout << "Prioridade baixa.\n";
            break;

        case 2:
            cout << "Prioridade media.\n";
            break;

        case 3:
            cout << "Prioridade alta.\n";
            break;

        default:
            cout << "Prioridade invalida.\n";
    }
}

void estatisticas() {
    if (chamados.empty()) {
        cout << "Nenhum chamado cadastrado.\n";
        return;
    }

    int abertos = 0;
    int em_andamento = 0;
    int resolvidos = 0;
    int cancelados = 0;

    for (Chamado chamado : chamados) {
        if (chamado.status == "Aberto")
            abertos++;
        else if (chamado.status == "Em andamento")
            em_andamento++;
        else if (chamado.status == "Resolvido")
            resolvidos++;
        else if (chamado.status == "Cancelado")
            cancelados++;
    }

    cout << "\n===== ESTATISTICAS =====\n";
    cout << "Abertos: " << abertos << endl;
    cout << "Em andamento: " << em_andamento << endl;
    cout << "Resolvidos: " << resolvidos << endl;
    cout << "Cancelados: " << cancelados << endl;
}

void Menu() {
    int opcao;

    do {
        cout << "\n========== MENU ==========\n";
        cout << "1 - Cadastrar chamado\n";
        cout << "2 - Listar chamados\n";
        cout << "3 - Atualizar status\n";
        cout << "4 - Estatisticas\n";
        cout << "5 - Sair\n";
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                cadastrarChamado();
                break;

            case 2:
                listarChamados();
                break;

            case 3:
                atualizarStatus();
                break;

            case 4:
                estatisticas();
                break;

            case 5:
                cout << "Saindo do programa...\n";
                break;

            default:
                cout << "Opcao invalida!\n";
        }

    } while (opcao != 5);
}

int main() {
    Menu();
    return 0;
}