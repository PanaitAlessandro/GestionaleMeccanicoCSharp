# GestionaleMeccanicoCSharp

**DISCLAIMER: I FATTI SONO FINTI. IL CODICE E' OPEN SOURCE PERCHE' NON ESISTE NESSUN CLIENTE.**

Ciao! Ho un'officina meccanica e vorrei un programma per gestirla. Ti spiego cosa mi serve.

## I veicoli

Nella mia officina passano moto, auto normali e auto elettriche. Ognuna ha targa, marca, modello, chilometraggio. Le moto hanno una cilindrata. Le auto (normali) hanno il numero di porte. Le elettriche hanno l'autonomia in km e per carità, non hanno cilindrata, non ha senso chiedergliela.

Ogni veicolo appartiene a un cliente (nome, cognome, telefono). Un cliente può avere più veicoli.

## I meccanici

Lavorano nella mia officina, hanno nome e una specializzazione (es. "motori", "elettronica", "carrozzeria"). I meccanici non sono legati a un veicolo specifico , sono dell'officina, lavorano su qualsiasi veicolo arrivi.

## Gli interventi

Quando un veicolo entra in officina, viene aperto un intervento: che veicolo, che meccanico se ne occupa, che data, una descrizione del problema, e quando viene chiuso il costo finale. Un intervento è legato a UN veicolo preciso e non ha senso se il veicolo non esiste più , se butto via il veicolo, mi aspetto sparisca anche la sua storia di interventi.

## Il calcolo del costo

Voglio poter chiedere al programma "quanto mi costa il tagliando di questo veicolo" e ottenere un numero diverso a seconda che sia moto, auto o elettrica , ognuna ha una sua formula (tu decidi formule sensate, tipo più cilindrata = più caro per la moto, ecc.).

## La fattura

Sia un intervento chiuso, sia , se un giorno aggiungo un noleggio , un noleggio, devono poter "dire quanto costano" e "generare una riga di fattura leggibile" nello stesso identico modo, anche se sono due cose completamente diverse tra loro (un intervento non è un tipo di noleggio, e viceversa). Voglio poter fare una lista mista di "cose fatturabili" e sommare tutto insieme senza fare un controllo diverso per ognuna.

## Errori che mi devono avvisare, non far crashare tutto

- Se cerco un veicolo con una targa che non esiste in officina.
- Se provo a chiudere un intervento che non ha ancora un costo assegnato.
- Se inserisco un chilometraggio o un costo negativo.

## Cosa voglio poter fare dal programma

(i "pulsanti", messi giù come idea, non impormi la forma esatta):

- Registrare un nuovo cliente con i suoi veicoli.
- Aggiungere un meccanico all'officina.
- Aprire un intervento su un veicolo, assegnandolo a un meccanico.
- Chiudere un intervento con un costo.
- Calcolare il costo tagliando "stimato" di un veicolo, prima ancora di aprire un intervento.
- Cercare un veicolo per targa, e se non c'è avvisarmi chiaramente invece di far esplodere tutto.
- Vedere lo storico interventi di un veicolo.
- Vedere il totale fatturato dell'officina, sommando tutti gli interventi chiusi (e in futuro anche altre cose fatturabili).
- Stampare/vedere l'elenco di tutti i meccanici e tutti i veicoli attualmente in officina.

## Nota finale

Fammi un programma vero, con dati veri inseriti a mano nel Main (anche solo 2-3 clienti, 4-5 veicoli, un paio di meccanici, qualche intervento), che gira davvero e mi stampa i risultati. Non deve essere perfetto al primo colpo , se sbaglio qualcosa dimmelo come hai fatto finora, con gli errori veri del compilatore.