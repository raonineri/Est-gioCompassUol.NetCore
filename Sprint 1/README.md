# Avaliação Sprint 1

Estagiário: Raoni Neri👨🏽‍💻

## Tema:  Segurança de redes: conheça as vulnerabilidades de servidores e clientes 🌐



1. O que é um ataque DDoS e como posso me proteger?

   R- 

   Um ataque DDoS ( *Distributed Denial of Service*) pode ser descrito como um "aprimoramento" do Ataque de Negação de Serviço (da sigla em inglês DOS). Ambos podem ser entendidos como uma sobrecarga do sistema ou aplicação. O DDoS consiste em um modelo onde o ataque não mais parte de um único usuário (como é feito no DOS), mas sim de um conjunto de máquinas, sendo seu objetivo tornar alguma aplicação ou serviço indisponível.  

   No caso de ataques DOS podemos fazer uso de algumas ferramentas para nos proteger, como o IDS (*Intrusion Detection System*) que espelha o trafego da rede e caso alguma anomalia seja detectada alarmes são disparados para que os administradores possar estar cientes e procurar uma solução. Também podemos usar o IPS (*Intrusion Prevention System*) que é conectado diretamente a rede e é capaz de prevenir anomalias que eventualmente aconteçam. 

   Contudo, quando se trata de um ataque do tipo DDoS se torna muito mais difícil sua detecção. Tendo em vista que, por princípio a investida parte de vários dispositivos e que podem estar distribuídos pelo mundo, o que torna difícil a distinção de um acesso legítimo de um mal-intencionado. 

   As máquinas que participam do ataque muitas vezes são sequestradas através de vírus e malwares, o termo para se referir a elas é *botnets*.

   

2. Por que o firewall é uma ferramenta muito importante de proteção? 

   R-

   O firewall é uma importante ferramenta para proteção de redes, pode vir embutido no roteador ou ser um equipamento dedicado. Atuando com o conceito de zonas de segurança, o firewall consegue delimitar diferentes níveis de segurança para cada uma de suas “zonas”. Com isso, o firewall é capaz de separar uma rede teoricamente segura (interna) de uma não segura (a exemplo da internet) e assim controlar o trafego entre as zonas de segurança (entre as redes).  Em outras palavras, usuários da rede interna terão permissão de acessar recursos que se encontram na rede externa, contudo usuários externos não terão autorização para se comunicar com a rede interna.

   Além disso o firewall é capaz de permitir a criação de uma região que se convencionou chamar de desmilitarizada (DMZ), nesta zona é possível alocar recursos da rede que podem ser acessados por usuários externos. Dessa forma é possível isolar dentro da rede interna a região que precisa ser acessada por usuários externos, dos recursos que só usuários da rede interna devem acessar.  

   

## Tema: Git e GitHub :octocat:



3. Explique de forma sucinta, o fluxo e envio de um arquivo novo para o repositório do projeto

   R - 

   Em um repositório *Git* temos três estágios ou áreas, a primeira delas é o *Working Directory*, ao realizar alterações nos arquivos monitorados pelo *Git*, podemos envia-los, com o comando `git add {nomeDoArquivo} ` para a *Staging Area*. Lá os arquivos estarão prontos para serem enviados ao *.git directory* (o repositório do projeto) com o comando `git commit`.    

   

4. Descreva sobre os ganhos de se utilizar a funcionalidade da *branch* do *git*

   R - As *branch* (ou ramificações) no *Git* servem para que seja possível construir divergências em relação a linha principal de desenvolvimento e assim poder continuar trabalhando sem realizar alterações na *main/master*.  A partir das ramificações é possível lançar mão de estratégias de branchs, que nada mais é do que um *workflow* utilizado pelas equipes de desenvolvimento. Alguns exemplos são: *Git Flow*, *Github Flow*, *Gitlab Flow*, etc.

   

5. Explique a diferença entre criar o repositório na nuvem e iniciar o repositório a partir de um código existente local.

   R -

   Um repositório *Git* pode ser criado localmente ou remotamente (na nuvem ou em um servidor local, por exemplo).  A diferença entre ambos está basicamente na possibilidade de tornar o projeto acessível a outras pessoas. Um repositório criado localmente, na minha máquina, é acessível a mim, enquanto criá-lo na nuvem o torna disponível, de forma pública ou privada (controlada), para outros indivíduos. 

   

6. Qual a diferença entre Git e GitHub:

   R - 

   O *Git* é um *Version Control System* (VCS), ou sistema de controle de versão, distribuído, de código aberto e amplamente usado. Com ele é possível termos controle em relação ao fluxo de trabalho de nossos projetos, mantendo o histórico de nossos arquivos. O que torna possível "voltar no tempo" e verificar o estado do código em versões anteriores e até as comparando entre si em busca de *bugs*. Por ser distribuído, o *Git* também nos permite trabalhar de forma conjunta com outros programadores, com o uso de repositórios remotos.

   O *GitHub*, por sua vez, é um serviço baseado em nuvem que hospeda repositórios *Git*, mas além disso também poder ser considerado uma rede social de desenvolvedores e a "casa" da maioria dos projetos *Open Source*. Além disso, o *GitHub* permite a colaboração entre seus usuários, possibilitando que desenvolvedores façam ou sugiram alterações em projetos compartilhados. 



## Tema: Fundamentos de Agilidade: seus primeiros passos para a transformação ágil :running_man:



7. Quais as principais diferenças entre o modelo ágil e o *waterfall* (modelo em cascata)?

   R-

   O modelo em cascata pode ser classificado como um modelo rígido, caracterizado pela imutabilidade (dos requisitos), priorização por etapas e *feedback* tardio. O modelo ágil, por sua vez, ataca diretamente essas características. No *Agile* temos três principais distinções em relação ao *waterfall*: 

   1) __Priorização__: Os requisitos são definidos aos poucos a partir de critérios de priorização, não há imutabilidade;
   2) __Fluxo__: Em vez de trabalhar por etapas, será focado em funcionalidades. Segmentando a entrega em pequenas metas, determinasse o que tem maior prioridade focando no que mais importa. 
   3) __*Feedbacks* Rápidos__: A entrega na ordem de priorização permite entregas mais rápidas que por sua vez possibilita *feedbacks* mais rápidos que podem ou não mudar as priorizações. 

   

8. Quais são as 3 perguntas que devem ser respondidas na Daily?

   R -

   * O que fez desde a última *Daily Scrum*?

   * O que fará até a próxima?

   * Quais problemas enfrentou?

     

9. Qual o intuito das seguintes cerimônias?

   * Daily: Resolver obstáculos que podem aparecer no dia a dia e para que todos possam saber o andamento das histórias na *Sprint*;

   * Planning: A Reunião, que da inicio a *sprint*, de planejamento que serve para dar o entendimento a respeito dos itens que serão feitos, planejando o que cabe no tempo disponível e definindo as metas do time;

   * Refinamento: O *Zooming* ou refinamento é um processo ligado ao *Product Backlog* (requisitos ou listas de pendências) onde o *Product Owne* confirma as prioridades com o cliente, melhora sua clareza e quebra grandes funcionalidades em partes menores que já agregarão algum valor par o cliente;

   * Review: É o momento da *sprint* onde cliente e desenvolvedores participam e tem como objetivo mostrar o que ficou pronto para o cliente (se possível o usuário ou pessoa mais próxima a ele), onde este último experimenta as funcionalidades produzidas na *sprint* e devolve *feedbacks*.  

   * Retrospectiva: É o último *timebox* dentro de uma *sprint*, um momento para refletir sobre o que deu certo (e por isso deve ser mantido) e o que não foi bom (para assim mudar / melhorar). É a oportunidade para promover melhorias no processo, no time e no andamento do projeto. Também é um dos objetivos da retrospectiva pôr em prática o conceito de melhoria contínua.

     

10. O que é a estimativa na metodologia ágil? 

    R- 

    A estimativa em um *framework* ágil (como o *scrum* e *kanban*) é a tentativa por parte da equipe de metrificar a quantidade de trabalho as quais podem se comprometer. No *kanban*, por exemplo, há duas métricas que ajudam a produzir essas estimativas: 1) a *lead time*, o tempo que um item leva para percorrer todo o fluxo do projeto; 2) o *cycle time*, o tempo em que um item fica em parte do processo. 



## Tema: Fundamentos HTTP :package:



11. O que é o protocolo HTTP? Qual a diferença entre HTTP e HTTPS?

    R - 

    O HTTP (*Hypertext Transfer Protocol*) é um protocolo de comunicação, seu papel é estabelecer um conjunto de regras de comunicação para que no modelo Cliente-Servidor a requisição e resposta possam se comunicar através das mesmas regras. O HTTP trefega texto puro, isto pode gerar falhas de segurança, pois há *N* intermediários desde o cliente até a aplicação no servidor. Para contornar esta falha de segurança foi criado o HTTPS, que nada mais é do que o HTTP com um protocolo de criptografia, `HTTPS = HTTP + SSL/TLS` (*Hypertext Transfer Protocol* +  *Secure Sockets Layer /  Transport Layer Security*).  

12. Cite 4 métodos HTTP.

    R -

    * `GET`: receber dados 

    * `POST`: criar algo novo no servidor

    * `DELET`: remover um recurso

    * `PUT`: atualizar um recurso

    Embora o HTTP especifico um padrão para o que seus métodos farão, contudo sua real funcionalidade dependerá do que foi definido pelos desenvolvedores da aplicação. 

