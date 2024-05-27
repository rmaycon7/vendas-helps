const getCNPJ = () => {
	let cnpj = "37628401000109";
	// https://receitaws.com.br/v1/cnpj/{cnpj}

	// const data = null;

	// const xhr = new XMLHttpRequest();
	// xhr.withCredentials = true;

	// xhr.addEventListener("readystatechange", function () {
	// 	console.log("arroz");
	// 	if (this.readyState === this.DONE) {
	// 		console.log(this.responseText);
	// 	}
	// });

	// xhr.open("GET", "https://receitaws.com.br/v1/cnpj/" + cnpj);
	// xhr.setRequestHeader("Accept", "application/json");

	// xhr.send(data);

	let myHeaders = new Headers();

	let myInit = {
		method: "GET",
		headers: {
			Accept: "application/json",
			"Access-Control-Allow-Origin":
				"*",
		},
		mode: "cors",
		cache: "default",
	};

	// fetch(`https://receitaws.com.br/v1/cnpj/37628401000109`, {
	// 	method: "GET",
	// 	headers: {
	// 		Accept: "application/json",
	// 		"Access-Control-Allow-Origin": "*",
	// 	},
	// 	mode: "cors",
	// 	cache: "default",
	// }).then(
	// 	(response) => {
	// 		console.log(response);
	// 	},
	// );
	// console.log(axios);

	// problema: acessar a api pelo navegador.
	// solução: criar uma api que apenas redirecioan o conteudo da requisição. para resolver o problema do cors.

	axios.get(`https://receitaws.com.br/v1/cnpj/${cnpj}`, {
		withCredentials: false,
		crossdomain: true,
		crossDomain: true,
		headers: {
			// Vary: "Origin, Access-Control-Request-Headers",

			// Accept: "application/json",
			origin: "https://developers.receitaws.com.br",
			"access-control-allow-origin": true,
			// "Content-Type":
			// 	"application/x-www-form-urlencoded; charset=UTF-8",
			authority: "receitaws.com.br",
			// method
			method: "GET",
			// scheme: "https",
			// "Accept-Encoding": "gzip, deflate, br, zstd",
			// "Cache-Control": "max-age=0",
			// "Sec-Fetch-Dest": "document",
			// "User-Agent":
			// "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36",
			// "Upgrade-Insecure-Requests": 1,

			// "Access-Control-Allow-Origin": "*",
			// "Access-Control-Allow-Credentials": true,
			// crossorigin: true,
		},
		// mode: "no-cors",
		// withCredentials: false,
		// crossdomain: true,
	})
		.then(function (response) {
			console.log(
				"teste requisição"
			);
			// console.log(response);
			// console.log('teste');
			// manipula o sucesso da requisição
			// makeSituacoes(response.data.uf);
			// console.log(response);
		})
		.catch(function (error) {
			// manipula erros da requisição
			// console.error(error);
			console.log(
				"teste requisição erro"
			);
			// alert("Erro ao buscar CNPJ");
		})
		.finally(function () {
			// sempre será executado
		});
};

// let siglaufs=['AC','AL','AM','AP','BA','CE','DF','ES','GO','MA','MG','MS','MT','PA','PB','PE','PI','PR','RJ','RN','RS','RO','RR','SC','SP','SE','TO']
const ufs = {
	AC: [
		"069 Não Contribuinte Externo 19%",
		"33 Contribuinte Externo - 19% > 17,5%",
		"63 Consumidor Externo 19% > 17,5%",
		"53 Orgao Publico Federal - Fora 19%",
		"62 Orgao Publico Prefeitura - Fora 19%",
	],
	AL: [
		"069 Não Contribuinte Externo 19%",
		"33 Contribuinte Externo - 19% > 17,5%",
		"63 Consumidor Externo 19% > 17,5%",
		"53 Orgao Publico Federal - Fora 19%",
		"62 Orgao Publico Prefeitura - Fora 19%",
	],
	AM: [
		"068 Não Contribuinte Externo 20%",
		"54 Orgao Publico Federal - Fora 20%",
		"63 Orgao Publico Prefeitura - Fora 20%",
		"084 Revenda Externo 20%",
	],
	AP: [
		"066 Não Contribuinte Externo 18%",
		"32 Contribuinte Externo - 18%",
		"34 Revenda 18% MG p/ ST Regime Especial",
		"35 Revenda 18% MG p/ ST Pneus Camara",
		"36 Revenda 18% SP p/ ST Pneus Camara",
		"38 Revenda Externo - 17% TO ST 72,79% ",
		"62 Consumidor Externo 18%",
		"82Revenda Externo 18%p/MG SP RS-35,36,37",
		"56 Orgao Publico Federal - Fora 18%",
		"79 Orgao Publico Prefeitura - Fora 18%",
	],
	BA: [
		"111 Não Contribuinte Externo 21%",
		"52 Orgao Publico Federal - Fora 21%",
		"64 Orgao Publico Prefeitura - Fora 21%",
		"085 Revenda Externo 21%",
	],
	CE: [
		"068 Não Contribuinte Externo 20%",
		"54 Orgao Publico Federal - Fora 20%",
		"63 Orgao Publico Prefeitura - Fora 20%",
		"084 Revenda Externo 20%",
	],
	DF: [
		"068 Não Contribuinte Externo 20%",
		"54 Orgao Publico Federal - Fora 20%",
		"63 Orgao Publico Prefeitura - Fora 20%",
		"084 Revenda Externo 20%",
	],
	ES: [
		"065 Não Contribuinte Externo 17%",
		"031 Contribuinte Externo - 17%",
		"037 Revenda 17% RS p/ ST Pneus Camara",
		"038 Revenda Externo - 17% TO ST 72,79% ",
		"061 Consumidor Externo 17%",
		"055 Orgao Publico Federal - Fora 17%",
		"070 Orgao Publico Prefeitura - Fora 17%",
	],
	GO: [
		"002 Não Contribuinte Interno",
		"001 Contribuinte Interno",
		"005 Consumidor Interno",
		"007 Revenda Interno",
		"015 Orgao Publico Federal - GO",
		"115 Orgao Publico prefeitura - GO",
	],
	MA: [
		"112 Não Contribuinte Externo 22%",
		"114 Orgao Publico Prefeitura - Fora 22%",
		"086 Revenda Externo 22%",
	],
	MG: [
		"066 Não Contribuinte Externo 18%",
		"32 Contribuinte Externo - 18%",
		"34 Revenda 18% MG p/ ST Regime Especial",
		"35 Revenda 18% MG p/ ST Pneus Camara",
		"36 Revenda 18% SP p/ ST Pneus Camara",
		"38 Revenda Externo - 17% TO ST 72,79% ",
		"62 Consumidor Externo 18%",
		"82Revenda Externo 18%p/MG SP RS-35,36,37",
		"56 Orgao Publico Federal - Fora 18%",
		"79 Orgao Publico Prefeitura - Fora 18%",
	],
	MS: [
		"065 Não Contribuinte Externo 17%",
		"031 Contribuinte Externo - 17%",
		"037 Revenda 17% RS p/ ST Pneus Camara",
		"038 Revenda Externo - 17% TO ST 72,79% ",
		"061 Consumidor Externo 17%",
		"055 Orgao Publico Federal - Fora 17%",
		"070 Orgao Publico Prefeitura - Fora 17%",
	],
	MT: [
		"065 Não Contribuinte Externo 17%",
		"031 Contribuinte Externo - 17%",
		"037 Revenda 17% RS p/ ST Pneus Camara",
		"038 Revenda Externo - 17% TO ST 72,79% ",
		"061 Consumidor Externo 17%",
		"055 Orgao Publico Federal - Fora 17%",
		"070 Orgao Publico Prefeitura - Fora 17%",
	],
	PA: [
		"069 Não Contribuinte Externo 19%",
		"33 Contribuinte Externo - 19% > 17,5%",
		"63 Consumidor Externo 19% > 17,5%",
		"53 Orgao Publico Federal - Fora 19%",
		"62 Orgao Publico Prefeitura - Fora 19%",
	],
	PB: [
		"112 Não Contribuinte Externo 22%",
		"114 Orgao Publico Prefeitura - Fora 22%",
		"086 Revenda Externo 22%",
	],
	PE: [
		"111 Não Contribuinte Externo 21%",
		"52 Orgao Publico Federal - Fora 21%",
		"64 Orgao Publico Prefeitura - Fora 21%",
		"085 Revenda Externo 21%",
	],
	PI: [
		"111 Não Contribuinte Externo 21%",
		"52 Orgao Publico Federal - Fora 21%",
		"64 Orgao Publico Prefeitura - Fora 21%",
		"085 Revenda Externo 21%",
	],
	PR: [
		"068 Não Contribuinte Externo 20%",
		"54 Orgao Publico Federal - Fora 20%",
		"63 Orgao Publico Prefeitura - Fora 20%",
		"084 Revenda Externo 20%",
	],
	RJ: [
		"112 Não Contribuinte Externo 22%",
		"114 Orgao Publico Prefeitura - Fora 22%",
		"086 Revenda Externo 22%",
	],
	RN: [
		"066 Não Contribuinte Externo 18%",
		"32 Contribuinte Externo - 18%",
		"34 Revenda 18% MG p/ ST Regime Especial",
		"35 Revenda 18% MG p/ ST Pneus Camara",
		"36 Revenda 18% SP p/ ST Pneus Camara",
		"38 Revenda Externo - 17% TO ST 72,79% ",
		"62 Consumidor Externo 18%",
		"82Revenda Externo 18%p/MG SP RS-35,36,37",
		"56 Orgao Publico Federal - Fora 18%",
		"79 Orgao Publico Prefeitura - Fora 18%",
	],
	RS: [
		"065 Não Contribuinte Externo 17%",
		"031 Contribuinte Externo - 17%",
		"037 Revenda 17% RS p/ ST Pneus Camara",
		"038 Revenda Externo - 17% TO ST 72,79% ",
		"061 Consumidor Externo 17%",
		"055 Orgao Publico Federal - Fora 17%",
		"070 Orgao Publico Prefeitura - Fora 17%",
	],
	RO: [
		"068 Não Contribuinte Externo 20%",
		"54 Orgao Publico Federal - Fora 20%",
		"63 Orgao Publico Prefeitura - Fora 20%",
		"084 Revenda Externo 20%",
	],
	RR: [
		"068 Não Contribuinte Externo 20%",
		"54 Orgao Publico Federal - Fora 20%",
		"63 Orgao Publico Prefeitura - Fora 20%",
		"084 Revenda Externo 20%",
	],
	SC: [
		"065 Não Contribuinte Externo 17%",
		"031 Contribuinte Externo - 17%",
		"037 Revenda 17% RS p/ ST Pneus Camara",
		"038 Revenda Externo - 17% TO ST 72,79% ",
		"061 Consumidor Externo 17%",
		"055 Orgao Publico Federal - Fora 17%",
		"070 Orgao Publico Prefeitura - Fora 17%",
	],
	SP: [
		"066 Não Contribuinte Externo 18%",
		"32 Contribuinte Externo - 18%",
		"34 Revenda 18% MG p/ ST Regime Especial",
		"35 Revenda 18% MG p/ ST Pneus Camara",
		"36 Revenda 18% SP p/ ST Pneus Camara",
		"38 Revenda Externo - 17% TO ST 72,79% ",
		"62 Consumidor Externo 18%",
		"82Revenda Externo 18%p/MG SP RS-35,36,37",
		"56 Orgao Publico Federal - Fora 18%",
		"79 Orgao Publico Prefeitura - Fora 18%",
	],
	SE: [
		"069 Não Contribuinte Externo 19%",
		"33 Contribuinte Externo - 19% > 17,5%",
		"63 Consumidor Externo 19% > 17,5%",
		"53 Orgao Publico Federal - Fora 19%",
		"62 Orgao Publico Prefeitura - Fora 19%",
	],
	TO: [
		"068 Não Contribuinte Externo 20%",
		"54 Orgao Publico Federal - Fora 20%",
		"63 Orgao Publico Prefeitura - Fora 20%",
		"084 Revenda Externo 20%",
	],
};
// let goias =['002 Não Contribuinte Interno','001 Contribuinte Interno','005 Consumidor Interno','007 Revenda Interno','015 Orgao Publico Federal - GO','115 Orgao Publico prefeitura - GO']

const makeSituacoes = (uf) => {
	console.log(uf);
	console.log(ufs[uf]);
	let lista = ``;

	for (let i in ufs[uf]) {
		let situa = ufs[uf][i];
		console.log(ufs[uf][i]);

		lista += ` <li class="list-group-item">${situa}</li> `;
	}
	let listSituacoes = `<div class="card">
             <div class="card-body">
                 <ul class="list-group">

                     ${lista}

                 </ul>
             </div>
           </div>`;
	let mainlist = document.getElementById("mainList");
	mainlist.innerHTML = listSituacoes;
};

const getCep = () => {
	let cep = document.getElementById("cep").value;
	axios.get("https://viacep.com.br/ws/" + cep + "/json/")
		.then(function (response) {
			// console.log(response);
			// console.log('teste');
			// manipula o sucesso da requisição
			makeSituacoes(
				response
					.data
					.uf
			);
			console.log(
				response
			);
		})
		.catch(function (error) {
			// manipula erros da requisição
			console.error(
				error
			);
			alert(
				"Erro ao buscar CEP"
			);
		})
		.finally(function () {
			// sempre será executado
		});
};
let textCepFocus = () => {
	let cep = document.getElementById("cep");
	cep.focus();
};

let cep = document.getElementById("cep");
// axios.get('https://viacep.com.br/ws/23895280/json/')
//     .then(function (response) {
//         // console.log(response);
//         // console.log('teste');
//         // manipula o sucesso da requisição
//         console.log(response);
//     })
//     .catch(function (error) {
//         // manipula erros da requisição
//         console.error(error);
//     })
//     .finally(function () {
//         // sempre será executado

//     });

let teste = {
	nome: "jose",
	marcas: [],
};

//   https://apigateway.conectagov.estaleiro.serpro.gov.br/api-cnpj-basica/v2/basica/

// axios.get('https://apigateway.conectagov.estaleiro.serpro.gov.br/api-cnpj-basica/v2/basica/').then(function (response) {
//     console.log(response);
// })

let textUpperFocus = () => {
	let textUpper = document.getElementById("textupper");
	textUpper.focus();
	// console.log('upper');
};
let clearTextUpper = () => {
	let textUpper = document.getElementById("textupper");
	textUpper.value = "";
	textUpper.focus();
};

let textInput = document.getElementById("textupper");
textInput.focus();
// window.setInterval(() => {
//     textInput.focus()
// }, 5000);
function uppperText() {
	let textToUpper = document.getElementById("textupper");

	let textUppered = textToUpper.value.toUpperCase();
	// let showTextUpper = document.getElementById('textuppered')
	// showTextUpper.value = textUppered
	navigator.clipboard.writeText(textUppered);
	let dataTotal = new Date();
	// console.log(dataTotal.toLocaleDateString())
	let obsCadastroText = `
CLIENTE VENDAS ECOMMERCE, MERCADO LIVRE, VENDA NO CARTÃO 1X </br>

\\\\\\ CONSULTADO SERASA DIA ${dataTotal.toLocaleDateString()}, NADA CONSTA, DATA DE NASCIMENTO: ..., SITUAÇÃO DO CPF: REGULAR CADASTRAL em ${dataTotal.toLocaleDateString()} ///</br>

\\\\\\ COMPRA FEITA PELO SR: ${textUppered}, E QUEM RETIRA MERCADORIA ///</br>
`;
	let obsCadastro =
		document.getElementById(
			"obsCadastro"
		);
	// obsCadastro.value=obsCadastroText

	let osbcard = document.getElementById("obscard");
	osbcard.innerHTML = obsCadastroText;
}

function setObsToClipBoard() {
	// body...
	// let obsCadastro= document.getElementById('obsCadastro')
	let osbcard = document.getElementById("obscard");
	// osbcard.contenteditable=true
	// osbcard.focus()
	let osbcardText = osbcard.textContent;
	navigator.clipboard.writeText(osbcardText);
}

textInput.addEventListener("input", uppperText);
