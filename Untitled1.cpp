#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct candidato{
	char nome[50];
	char partido[50];
	int num;
}cad;


read(candidato *cad, int i){
	for(int i=0;i<3;i++){
	FILE *pont_arq;
	pont_arq = fopen("candidato.txt", "a");
	if (pont_arq == NULL)
		{
   		 printf("ERRO! O arquivo não foi aberto!\n");
		}
	
	printf("inserir nome: ");
	gets(cad[i].nome);
	fprintf(pont_arq, "%s ", cad[i].nome);
	printf("Inserir partido: ");
	gets(cad[i].partido);
	fprintf(pont_arq, "%s ", cad[i].partido);
	printf("Inserir num :");
	scanf("%d", &cad[i].num);
	fprintf(pont_arq, "%d\n", cad[i].num);
	fflush(stdin);
	fclose(pont_arq);
    }
}

show(candidato *cad, int i){
	FILE *pont_arq;
	char texto_str[20];

	pont_arq = fopen("candidato.txt", "r");
	while(fgets(texto_str, 20, pont_arq) != NULL)
    printf("%s", texto_str);

    
}

struct cpf{
	char nomec[50];
	 int *ncpf;
	}*cpff;

reads(cpf *cpff, int a){
	*cpff;
	int teste;
	FILE *arq;
	arq = fopen("cpf.txt", "a");
	if (arq == NULL)
		{
   		 printf("ERRO! O arquivo não foi aberto!\n");
		}
	
	//printf("inserir nome: ");
	//gets(cpff[a].nomec);
	//fprintf(arq, "%s ", cpff[a].nomec);
	printf("Inserir CPF: ");
	//long int *ncpf = (long int*)malloc(70*sizeof(long int));
	scanf("%li", &cpff[a].ncpf);
	fprintf(arq, "%d\n", cpff[a].ncpf);

	fflush(stdin);
	fclose(arq);

	fflush(stdin);
	fclose(arq);
    
}
main(){
	struct candidato cad[4];
	struct cpf cpff[2];
	int i, op;
    printf("Voce quer cadastrar ou ler?\n ");
    printf("1)Cadastrar\n2)Ler\n3)Votar");
    scanf("%d", &op);
    fflush(stdin);
    switch(op){
    	case 1:
    		read(cad, i);
    		break;
    	case 2:
    		show(cad, i);
    		break;
		case 3:
			reads(cpff, i);

			break;
			
	    	default:
    		system("pause");
	}


}
