fetch("./templates/header.html")
	.then((response) => {
		return response.text();
	})
	.then((data) => {
		document.querySelector(
			"header"
		).innerHTML = data;
	});

try {
	fetch("./footer.html")
		.then((response) => {
			if (
				response.status !=
				200
			) {
				throw new TypeError(
					"footer not found"
				);
			}
			// console.log(response.status);
			return response.text();
		})
		.then((data) => {
			console.log(
				{
					data,
				}
			);
			if (
				data
			) {
				document.querySelector(
					"footer"
				).innerHTML =
					data;
			}
		});
} catch (error) {}

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
const getCNPJ = () => {
	// let cnpj = "37628401000109";

	const cnpj = document
		.getElementById("cnpj")
		.value.replace(/[\D]/g, "");
	// console.log({ cnpj: cnpj });
	axios.get(
		`https://api.cnpjs.dev/v1/${cnpj}`,
		// `http://127.0.0.1:4000/v1/cnpj/${cnpj}`,
		{
			headers: {
				// Vary: "Origin, Access-Control-Request-Headers",

				Accept: "application/json",
				method: "GET",
			},
		}
	)
		.then(function (response) {
			console.log(
				"teste requisição"
			);
			// console.log(
			// 	response
			// );

			let {
				data,
			} =
				response;
			let {
				endereco,
				natureza_juridica,
				razao_social,
			} =
				data;
			let {
				uf,
				cep,
			} =
				endereco;
			console.log(
				{
					uf,
					natureza_juridica,
					razao_social,
				}
			);

			// getCep(cep)
			// getTextUpper
			let cepInput =
				document.getElementById(
					"cep"
				);
			cepInput.value =
				cep;
			makeSituacoes(
				uf
			);
			let uppperTextIpunt =
				document.getElementById(
					"textupper"
				);
			uppperTextIpunt.value =
				razao_social;

			uppperText();

			// console.log('teste');
			// manipula o sucesso da requisição
			// makeSituacoes(response.data.uf);
			// console.log(response);
		})
		.catch(function (error) {
			// manipula erros da requisição
			console.error(
				error
			);
			console.log(
				"teste requisição erro"
			);
			alert(
				"Erro, tente no"
			);
			// alert("Erro ao buscar CNPJ");
		});
	// .finally(function () {
	// 	// sempre será executado
	// });
};

// let siglaufs=['AC','AL','AM','AP','BA','CE','DF','ES','GO','MA','MG','MS','MT','PA','PB','PE','PI','PR','RJ','RN','RS','RO','RR','SC','SP','SE','TO']

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

const getCep = (cep) => {
	if (!cep) {
		cep = document
			.getElementById(
				"cep"
			)
			.value.replace(
				/[\D]/g,
				""
			);
	} else {
		cep = cep.replace(/[\D]/g, "");
	}
	navigator.clipboard.writeText(cep);
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
const textCepFocus = () => {
	let cep = document.getElementById("cep");
	cep.focus();
};

const textCNPJFocus = () => {
	let cnpj = document.getElementById("cnpj");
	cnpj.focus();
};
// let cep = document.getElementById("cep");
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
// textInput.focus();
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
// CLIENTE VENDAS ECOMMERCE, MERCADO LIVRE // </br>

// CONSULTADO CPF/CNPJ: NO PORTAL DA TRANSPARÊNCIA GOV. FEDERAL / RECEITA FEDERAL - EMISSÃO DE COMPROVANTE DE INSCR. CNPJ //<br>
// NO DIA ${dataTotal.toLocaleDateString()},  SITUAÇÃO DO CPF/CNPJ: REGULAR CADASTRAL EM ${dataTotal.toLocaleDateString()} //</br>

// COMPRA FEITA PELO SR: ${textUppered}, E QUEM RETIRA MERCADORIA //</br>
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

try {
	textInput.addEventListener("input", uppperText);
} catch (error) {}

const getTextUpper = () => {
	const textUpperInput =
		document.getElementById(
			"textupper"
		);
	let textuppered = textUpperInput.value.toUpperCase();
	textuppered = textuppered.replace(/(^[\s]+|[\s]+$)/g, '')
	textInput.value = textuppered;
	navigator.clipboard.writeText(textuppered);
	// SDSDASD
};

// uppperText();
const upperInput = document.getElementById("upper");

const upperFocus = () => {
	upperInput.focus();
};
try {
	upperInput.addEventListener("input", () => {
		upperInput.value =
			upperInput.value.toUpperCase();
		// console.log(upperInput.value);
		navigator.clipboard.writeText(
			upperInput.value
		);
	});
} catch (error) {}
const upper = () => {
	upperInput.value = upperInput.value.toUpperCase().replace(/(^[\s]+|[\s]+$)/g, '');
	navigator.clipboard.writeText(upperInput.value);
};

const priceFocus = () => {
	const priceInput = document.getElementById("price");
	priceInput.focus();
	const clipboardText = navigator.clipboard
		.readText()
		.then((text) => {
			if (
				priceInput.value !=
				text
			) {
				priceInput.value =
					text;
				price();
			}
		});
};

const mlbFrame = document.getElementById("mlb-frame");

try {
	const priceInput = document.getElementById("price");

	priceInput.addEventListener("input", () => {
		const mlb = priceInput.value;
		const url = `https://www.mercadolivre.com.br/simulador-de-custos?itemId=${mlb}`;
		mlbFrame.src = url;
	});
} catch (error) {}

const price = () => {
	const priceInput = document.getElementById("price");
	const mlbFrame = document.getElementById("mlb-frame");
	const mlb = priceInput.value;
	console.log(mlbFrame.src);
	const url = `https://www.mercadolivre.com.br/simulador-de-custos?itemId=${mlb}`;
	mlbFrame.src = url;
};

const priceInput = document.getElementById("price");
// Execute a function when the user presses a key on the keyboard
if (priceInput) {
	priceInput.addEventListener(
		"keypress",
		function (event) {
			// If the user presses the "Enter" key on the keyboard
			if (
				event.key ===
				"Enter"
			) {
				// Cancel the default action, if needed
				event.preventDefault();
				price();

				// Trigger the button element with a click
				// document.getElementById(
				// 	"myBtn"
				// ).click();
			}
		}
	);
}

const cleanInput = document.getElementById("cleanInput");

const clean = () => {
	// const cleanTextContent = cleanInput.value.replace(
	// 			/[\.\-\/\\^~\-\+\-\* \(\)]/g,
	// 	""
	// );

	const cleanTextContent = cleanInput.value.replace(
		/[\D]/g,
		""
	);
	navigator.clipboard.writeText(cleanTextContent);
	cleanInput.value = cleanTextContent;
};

const cleanFocus = () => {
	// console.log("aqui");
	try {
		cleanInput.focus();
		// console.log({ cleanInput });
	} catch (error) {}
};
