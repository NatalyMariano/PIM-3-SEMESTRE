# Projeto Totem de Museu Multitemático

## Visão Geral do Projeto
Este projeto tem como objetivo desenvolver um sistema de totens interativos para um museu multitemático. Esses totens permitem que os visitantes avaliem as exposições de arte em tempo real, fornecendo feedback valioso que pode ser utilizado pelos administradores do museu para melhorar a experiência do visitante. O sistema foi desenvolvido em C# utilizando a plataforma .NET e orientado por metodologias ágeis (Scrum e Kanban).

## Funcionalidades
- **Totens Interativos**: Totens posicionados estrategicamente no museu para que os visitantes avaliem as exposições.
- **Feedback em Tempo Real**: Os visitantes podem fornecer feedback em tempo real através de uma interface amigável.
- **Coleta e Análise de Dados**: O feedback é armazenado e analisado, fornecendo insights quantitativos e qualitativos para os administradores do museu melhorarem as exposições.
- **Gestão Segura de Dados**: Os dados coletados são gerenciados com segurança, protegendo a privacidade dos visitantes.

## Tecnologias Utilizadas
- **Linguagem de Programação**: C#
- **Framework**: .NET
- **Banco de Dados**: SQL Server (modelado com BRModelo)
- **Controle de Versão**: GitHub
- **Prototipação de Interface**: Balsamiq
- **Ferramentas de Modelagem**: StarUML, Draw.io
- **Gerenciamento de Tarefas**: Trello (metodologia Kanban)
- **Ambiente de Desenvolvimento**: Visual Studio

## Instalação
1. **Requisitos do Sistema**:
    - Windows 11 ou superior.
    - Framework .NET instalado.
    - Instância do SQL Server para armazenamento de dados.
    - Acesso à infraestrutura de rede do museu (Wi-Fi, LAN).

2. **Passos para Instalação**:
    - Clone o repositório do GitHub.
    - Abra a solução no Visual Studio.
    - Restaure os pacotes NuGet necessários.
    - Execute o projeto para visualizar a interface do totem.

3. **Configuração do Banco de Dados**:
    - Execute os scripts SQL fornecidos na pasta `/database` para configurar o esquema inicial.
    - Atualize a string de conexão no arquivo `appsettings.json` para apontar para sua instância do banco de dados.

## Uso
1. **Interação do Visitante**:
    - Na chegada, os visitantes serão recebidos com uma tela de boas-vindas, onde devem inserir seus nomes.
    - Em seguida, eles poderão avaliar as obras expostas, respondendo a uma série de perguntas (de 0 a 5).
    - Após avaliar todas as obras, o visitante verá um resumo do seu feedback.

2. **Acesso do Administrador**:
    - Os administradores podem acessar os feedbacks armazenados para análise.
    - Os dados coletados podem ser usados para ajustar e melhorar futuras exposições.


## Contato
Para mais informações ou suporte, entre em contato com a equipe de desenvolvimento:
- Julia Souza - 
- Luiz Oliveira - 
- Marcos Custodio - 
- Milleny Evangelista - 
- Nataly Pereira - [natalymp2003@gmail.com](natalymp2003@gmail.com)

