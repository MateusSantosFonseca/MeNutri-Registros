# MeNutri

### Sobre
Sistema desenvolvido em C#, utilizando Windows Forms e MetroFramework. Para persistência de dados, foi utilizado o Firebase Realtime Database.

### API's e Frameworks:

- **[MetroFramework](https://www.nuget.org/packages/Winform.Metroframework/)**: Utilização de seus componentes e estilos, auxiliando na beleza do layout e funcionalidade do sistema;

- **[ViaCEP](https://github.com/guibranco/ViaCEP)**: Para preenchimento automático dos campos de localização do registro através do preenchimento do CEP;

- **[FireSharp](https://github.com/ziyasal/FireSharp)**: Para comunicação com a base de dados, bem como as funcionalidades CRUD do sistema.

### Escopo do sistema:

#### Requisitos funcionais:

- **RF-01:** O sistema deve permitir ao usuário realizar login;

- **RF-02:** O sistema deve permitir ao usuário cadastrar um registro, atendendo à RN-01;

- **RF-03:** O sistema deve permitir ao usuário editar um registro;

- **RF-04:** O sistema deve permitir ao usuário excluir um registro;

- **RF-05:** O sistema deve permitir ao usuário visualizar todos os registros em uma tabela;

- **RF-06:** O sistema deve permitir ao usuário visualizar um único registro contendo todos seus atributos;

- **RF-07:** O sistema deve permitir ao usuário exportar todos os registros para um arquivo XLS;

- **RF-08:** O sistema deve permitir ao usuário exportar todos os registros para um arquivo PDF;

- **RF-09:** O sistema deve permitir ao usuário filtrar, através de um campo específico, em todos os registros, nos campos definidos em RN-02;

- **RF-10:** O sistema deve permitir ordenar os registros, de forma definida em RN-03;

- **RF-11:** O sistema deve permitir ao usuário a exclusão de todos os registros;

- **RF-12:** O sistema deve possuir preenchimento automático de campos após inserção do CEP;

- **RF-13:** O sistema deve permitir ao usuário remover todos os filtros da tabela.

#### Requisitos Não-Funcionais:

- **RNF-01:** O sistema deve ser desenvolvido utilizando C#, com Windows Form e MetroFramework;

- **RNF-02:** O sistema deve persistir seus dados utilizando o banco de dados NoSQL Firebase Realtime Database;

- **RNF-03:** O sistema deve logar qualquer erro em um arquivo .txt, atendendo a RN-04;

- **RNF-04:** Todas ações do sistema devem ter um feedback em mensagem para o usuário;

- **RNF-05:** Todas alterações no sistema devem atualizar automaticamente a tabela;

#### Regras de negócio:

- **RN-01:** Para efetuar o cadastro de um registro, devem ser providos no mínimo os atributos Tipo de Registro e Telefone;

- **RN-02:** Na filtragem dos dados, com o texto inserido pelo usuário, sua existência deve ser pesquisada em todos os registros nos campos: **nome**, **sobrenome**, **tipo de registro**, **estado**, **telefone**, **CPF** e **razão social**.

- **RN-03:** A ordenação do sistema poderá ser realizada através dos campos: **nome**, **razão social**, **tipo de registro**, **estado** ou **último horário de edição**.

- **RN-04:** Deverá ser criada uma pasta Logs, onde haverão os arquivos texto contendo os erros que eventualmente acontecerem no sistema. Estes arquivos texto deverão ser nomeados com a data de exceção no formato dd-MM-yyyy_hh-mm-ss mais o nome da exceção sem espaços precedido por _ (e.g. 06-04-2020_07-51-27_Erroaoincluirregistro e 06-04-2020_07-51-27_Erroaoincluirregistro). O conteúdo deste arquivo deve conter: **nome da exceção**, **data e horário da exceção**, **mensagem da excecão** e o **StackTrace da excecão**.

#### Observações:

Este software foi produzido gratuitamente para a empresa júnior MeNutri da Universidade Federal de Viçosa do Campus Rio Paranaíba. 

Estando este software sobre a licença MIT, este software pode ser distribuído, desde que haja a inclusão desta licença e do copyright. Além disso não há garantias do seu funcionamento sendo que este está fornecido no modelo AS IS.
