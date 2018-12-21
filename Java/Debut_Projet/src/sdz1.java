import java.util.Scanner;

public class sdz1 {

	public static void main(String[] args) {

Scanner sc = new Scanner(System.in);
double tempconvert;
int choix=0;
double temperature=0;
char reponse = 'o';
while(reponse == 'o')
	{
	System.out.println("");
	System.out.println("Bonjour, veuillez choisir le mode de convertion \n[1] Convertisseur Celsius - Fahrenheit"+
			"\n[2] Convertisseur Fahrenheit - Celsius ");
	choix = sc.nextInt();
	switch(choix)
	{
	case 1 :
		System.out.println("Entrer une température en degré Celsius");
		temperature = sc.nextDouble();
		tempconvert = (temperature*9/5)+32;
		tempconvert = Arrondi(tempconvert,2);
		System.out.println("la temperature de "+temperature+" degré Celsius vaux : "+tempconvert+" degré Fahrenheit");
		break;
	case 2 :
		System.out.println("Entrer une température en Farhenheit");
		temperature = sc.nextDouble();
		tempconvert = (temperature-32)*5/9;
		tempconvert = Arrondi(tempconvert,2);
		System.out.println("la temperature de "+temperature+" degré Fahrenheit vaux : "+tempconvert+" degré Celsius");
		break;
	}
	sc.nextLine();
	System.out.println("Voulez vous convertire une autre température? [o/n]");
	reponse = sc.nextLine().charAt(0);
	}

	
	

	
	
	sc.close();
	System.out.println("Au Revoir");
	}


public static double Arrondi(double temp, int nbrvirg)
{
	return (double) ((int) (temp*Math.pow(10, nbrvirg)+0.5)/ Math.pow(10, nbrvirg));
}
}
