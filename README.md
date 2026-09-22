#  GestionaleMeccanicoCSharp

Un semplice gestionale per officina meccanica, pensato per esercitare la programmazione orientata agli oggetti in C#.

>  **Focus del progetto**: OOP (ereditarietà, polimorfismo, interfacce). Non è incentrato su database o persistenza dei dati.

>  **Disclaimer**: tutti i dati presenti in questo progetto sono di finzione e non rappresentano la realtà (neanche questo README!).

---

##  Panoramica

L'officina gestisce tre tipi di veicoli (moto, auto, elettriche), un parco meccanici, e interventi di manutenzione. Il sistema deve permettere di registrare clienti e veicoli, aprire e chiudere interventi, calcolare costi stimati e reali, e tenere traccia del fatturato totale.

---

## 🏍️ Modello dei veicoli

Tutti i veicoli condividono un nucleo comune di attributi, poi si differenziano per caratteristiche specifiche.

| Attributo | Moto | Auto | Elettrica |
|---|:---:|:---:|:---:|
| Targa | ✅ | ✅ | ✅ |
| Marca | ✅ | ✅ | ✅ |
| Modello | ✅ | ✅ | ✅ |
| Chilometraggio | ✅ | ✅ | ✅ |
| Cilindrata | ✅ | ❌ | ❌ |
| Numero porte | ❌ | ✅ | ❌ |
| Autonomia (km) | ❌ | ❌ | ✅ |

**Vincolo importante**: un'auto elettrica non ha (e non deve poter avere) una cilindrata. La gerarchia delle classi deve riflettere questa distinzione in modo naturale, non con campi lasciati vuoti o ignorati.

---

## 👤 Clienti

Ogni cliente ha:

- Nome
- Cognome
- Telefono

Un cliente può possedere **più veicoli** (relazione uno a molti).

---

## 🔩 Meccanici

Ogni meccanico ha:

- Nome
- Specializzazione (es. "motori", "elettronica", "carrozzeria")

I meccanici appartengono all'officina, non a un veicolo specifico: lavorano su qualsiasi veicolo arrivi.

---

## 🛠️ Interventi

Quando un veicolo entra in officina viene aperto un intervento, che contiene:

- Il veicolo su cui si interviene
- Il meccanico assegnato
- La data
- Una descrizione del problema
- Il costo finale (assegnato alla chiusura)

**Regola di dipendenza**: un intervento è legato a un veicolo preciso e non ha senso senza di esso. Se il veicolo viene eliminato, deve sparire anche tutta la sua storia di interventi (relazione di composizione, non semplice associazione).

---

## 💰 Calcolo del costo tagliando

Il sistema deve poter rispondere alla domanda: *"quanto mi costa il tagliando di questo veicolo?"*, con un risultato diverso a seconda del tipo:

- **Moto**: il costo cresce con la cilindrata.
- **Auto**: il costo dipende da chilometraggio e numero di porte.
- **Elettrica**: il costo è generalmente inferiore (meno parti meccaniche), ma dipende dall'autonomia e dal chilometraggio.

Ogni tipo di veicolo implementa la propria formula. Il calcolo deve essere disponibile anche **prima** di aprire un intervento, come stima.

---

## 🧾 Fatturazione

Due concetti diversi tra loro (un intervento **non è** un tipo di noleggio, e viceversa) devono comportarsi allo stesso modo quando si tratta di fatturare:

- Un **intervento chiuso**
- Un eventuale **noleggio** futuro

Entrambi devono poter:

1. Dire quanto costano
2. Generare una riga di fattura leggibile

Questo comportamento comune deve essere espresso tramite un'**interfaccia** (o contratto astratto), così da poter costruire una lista mista di "cose fatturabili" e sommarne il totale senza controlli diversi caso per caso.

---

## 🚨 Gestione degli errori

Il programma deve **avvisare**, non crashare, nei seguenti casi:

| Situazione | Comportamento atteso |
|---|---|
| Ricerca di una targa che non esiste | Messaggio chiaro, nessuna eccezione non gestita |
| Chiusura di un intervento senza costo assegnato | Blocco dell'operazione con avviso |
| Inserimento di chilometraggio o costo negativo | Rifiuto del valore con avviso |

---

## ⚙️ Funzionalità richieste

Le seguenti operazioni devono essere disponibili (la forma esatta, menu a console o altro, è libera):

- [ ] Registrare un nuovo cliente con i suoi veicoli
- [ ] Aggiungere un meccanico all'officina
- [ ] Aprire un intervento su un veicolo, assegnato a un meccanico
- [ ] Chiudere un intervento con un costo
- [ ] Calcolare il costo tagliando stimato di un veicolo (senza aprire un intervento)
- [ ] Cercare un veicolo per targa, con avviso se non trovato
- [ ] Visualizzare lo storico interventi di un veicolo
- [ ] Visualizzare il totale fatturato dell'officina (interventi chiusi + eventuali altre voci fatturabili)
- [ ] Stampare l'elenco di tutti i meccanici e di tutti i veicoli in officina

---

<div align="center">

*Progetto realizzato da Alessandro Panait*

</div>