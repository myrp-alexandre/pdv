# PDV
Sistema para gerenciamento de Ponto de Venda


- Para rodar a migração pode ser pelo Package Manager Console (comando update-database) ou descomentado no arquivo *DatabaseConfiguration.cs*;
Observação: Só vale para primeira execução.

- No seed eu carrego somente os valores pedidos; 

- Funcionará em qualquer banco SqlServer. Basta trocar a conection string em *AppSettings/appsettings.Development.json*;

- Para os testes eu utilizo uma base com todos os valores em circulação (incluíndo o valor de 1 centavo);

- Os scripts do postman estão em https://www.getpostman.com/collections/8503b54945598f54ed1e

## Dívidas técnicas e observações:

- Trabalhei na master, mas nos sistemas que atuo utilizamos o gitflow com PR;

- Eu não utilizei nenhuma biblioteca para testes para essa prova. Mas normalmente eu utilizaria o Moq e o NBuilder;

- Eu fiz o mapeamento sem utilizar o AutoMapper. Nos sistemas que atuo atualmente também não utilizamos, pois o reflection consome ms das aplicações. Como o nível de criticidade é muito alto qualquer tempo tem muito valor;

- O método SetId da entidade Dinheiro é útil também quando precisamos utilizar um insert com SqlCommand e retornar a entidade com Id. Na prova eu utilizei para alimentar o Seed - No .NetCore é necessário informar um valor válido para o campo chave;

- Normalmente eu retorno menos informações para o front e também utilizo o gzip (embora não tenha aplicado na prova);

- Queria ter criado endpoints para Cadastro de Dinheiro e para listar as transações. Eu também colocaria uma data na transação (No próximo item explico);

- É possível criar um modelBinder para fazer toda parte de globalização (Data, números reais, por exemplo). Mas, nos sistemas que atudo já amarramos isso num framework. Por questões éticas não trouxe nada que utilizo em outras empresas. E o desenvolvimento dessa conversão consumiria muito tempo;

- O padrão que utilizei é um misto de DDD com Mensageria e alguma coisa de SOA. Na verdade, nos sistemas que atuo, separamos as services em EntityServices e TaskServices. A documentação pode ser vista abaixo. Eu não utilizei esse padrão na prova e também não acho válido para sistemas pequeno a médios. 
* http://serviceorientation.com/soaglossary/entity_service
* http://serviceorientation.com/soaglossary/task_service

Bom, procurei fazer o melhor. Agradeço a oportunidade em fazer essa prova. É sempre uma oportunidade para pesquisar e reforçar alguns conhecimentos ao desenvolver features que só se costuma fazer no início de um projeto.

Obrigado e estou à disposição para conversarmos!
