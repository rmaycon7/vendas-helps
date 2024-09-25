let teste = "73.801-190".replace(/[.-]/g, "");
console.log(teste);

let help;

const { exec } = require("node:child_process");
exec("clear");
const tetra = (a) => {
	// console.log(a);
	// return a == undefined?  "ude" : "undeffined a"
	// console.log()
};

// console.log(tetra());
// console.log(help == undefined? false: true )

const removeAccents = (str) =>
	str.normalize("NFD").replace(/[\u0300-\u036f]/g, "");

removeAccents("Antoine de Saint-Exupéry"); // 'Antoine de Saint-Exupery'
console.log(removeAccents("Antoine Japão"));

// esssa parte é para tratar e buscar usando comparação, a natureza jurica do cnpj

const axios = require("axios");
const { log } = require("node:console");
// const Fuse = require('fuse.js')

// // axios.get('https://api.cnpjs.dev/v1/00394684000153').then((response) =>{
//   axios.get('https://api.cnpjs.dev/v1/37628401000109').then((response) =>{
//   let {data} = response
//   let {endereco, natureza_juridica,razao_social} = data
//   let {uf} = endereco
//   console.log({uf,natureza_juridica, razao_social});
// })

// let list= ["Old Man's War", "The Lock Artist",'Municipio']
// const options = {
//   includeScore: true,
//   minMatchCharLength: 3
// }

// const fuse = new Fuse(list,options)

// const result = fuse.search('ti')
// console.log(result);

// const reg = /\d{3}/g;
// const str = "Java323Scr995ip4894545t";
// const newStr = str.replace(reg, "");
// console.log(newStr);
const word = "freecodecamp";

const capitalized = word.charAt(0).toUpperCase() + word.slice(1);
const cgcs = [
	// "34079466000146",
	"12340168000125",
	"46749181000154",
	"20816711000146",
	"04868874000116",
	"89865839687",
	"19368324000105",
	"29985673000120",
	"15104372000135",
	"06202510000128",
	"07691554000121",
	"08593409610",
	"04696286000142",
	"24849536000144",
	"46959351634",
	"36713976000159",
	"42554534000100",
	"11292761000261",
	"11292761000180",
	"29559817000186",
	"09452911000124",
	"22458251000157",
	"03790619000135",
	"38052431000174",
	"13559896000195",
	"11143056000111",
	"00340740000177",
	"37983549000153",
	"00772005605",
	"19941850000112",
	"29835414000112",
	"10285685686",
	"03170385000123",
	"12018550000117",
	"19279564000133",
	"32708020000108",
	"14489474000153",
	"15138189000150",
	"10729141000101",
	"12948802687",
	"07592359000144",
	"32664561000181",
	"10481509000157",
	"04143784000168",
	"20787082000173",
	"25588532600",
	"83445030600",
	"27346309000194",
	"33585825000174",
	"07754288000139",
	"16858431000123",
	"44136697000106",
	"06350262000162",
	"33493090625",
	"24683817000170",
	"41101859000174",
	"20231299000100",
	"24635929000155",
	"04923070676",
	"37200274000134",
	"29944044000151",
	"26487049000104",
	"29467697000197",
	"08605233000120",
	"28659171000146",
	"31346472653",
	"14668903000230",
	"25283935000153",
	"28529944615",
	"15205108000198",
	"01723789000171",
	"38315243000191",
	"28818072000160",
	"07953184648",
	"08787028000122",
	"37144131000152",
	"09396731000172",
	"25604794000123",
	"08995501693",
	"15051570000188",
	"35691786000115",
	"08262116666",
	"21780793000189",
	"30217503000184",
	"00356328000145",
	"07472091000107",
	"28433048000102",
	"20159885000183",
	"07109963000177",
	"22139372000136",
	"09358606000178",
	"19565252000196",
	"05557068000190",
	"07727509000180",
	"02034727649",
	"33771341000110",
	"29780396000119",
	"25105936000108",
	"22187845000170",
	"09042014000142",
	"01485257689",
	"11155720000142",
	"14193315000107",
	"32784554000113",
	"32408004000108",
	"22377082000120",
	"45845042615",
	"29342472000104",
	"16930293000146",
	"31937038000119",
	"23165756000196",
	"02738746000203",
	"02341748000183",
	"17353673000128",
	"17994932000108",
	"29558549649",
	"71023188000131",
	"25535028000154",
	"17067640000111",
	"31898218000139",
	"68542984000176",
	"14072798000191",
	"32194959000100",
	"60199873615",
	"07190199000107",
	"42420989600",
	"25193561000185",
	"21382694000149",
	"25263237000196",
	"00216548000173",
	"31116555000127",
	"16815608000104",
	"31352733000119",
	"04326413000111",
	"26324995000130",
	"28784950000173",
	"29523330000143",
	"08815653000130",
	"71068654000103",
	"05353325000171",
	"26324995000210",
	"18975189000101",
	"05047553663",
	"29773784000172",
	"53283597634",
	"27297123000192",
	"52035530687",
	"23797053000180",
	"01466206000174",
	"13669325000103",
	"10341679000136",
	"10513061000106",
	"29231310000107",
	"66395930000108",
	"17557773000176",
	"09222328655",
	"11229520000197",
	"28933120000160",
	"13565915000196",
	"16810036000170",
	"12707318000196",
	"17243585000173",
	"21032545000150",
	"06320882000159",
	"24204320000121",
	"80869416634",
	"07930496000141",
	"06320882000230",
	"29574791000145",
	"10789344000185",
	"20234674000168",
	"02777722000182",
	"19753079000150",
	"03814698000177",
	"09396731000334",
	"03049750000146",
	"20516993000166",
	"20255728000171",
	"27533951000182",
	"09626985000130",
	"21992747000143",
	"07756386680",
	"19754572000194",
	"18973049000196",
	"10453573000124",
	"11401942000106",
	"25831090000193",
	"09080759000104",
	"19999980000106",
	"25847989000102",
	"02087258000100",
	"03195506000191",
	"05213508000191",
	"10959190000122",
	"71002125000107",
	"20945215000192",
	"23571943000170",
	"19230918000155",
	"15354097000108",
	"23038354000120",
	"19801624000136",
	"05560175000177",
	"17311358000138",
	"20992444000168",
	"08112721000367",
	"17289144000102",
	"09447934000302",
	"11768121000102",
	"11406647000134",
	"01446302000150",
	"11684322000113",
	"15717021000108",
	"71385777000160",
	"12674986000164",
	"07357192000137",
	"17089673000162",
	"26314690000147",
	"03501092000181",
	"14055541000121",
	"16800120000103",
	"00152350000173",
	"01237998000105",
	"23347255000120",
	"13209699000146",
	"08096663000244",
	"10940434000125",
	"25885393000784",
	"09719663000135",
	"00662065000100",
	"64121330625",
	"09447934000140",
	"18669368000102",
	"21557657000124",
	"03311769000119",
	"22001820000130",
	"05487631000109",
	"71149983000170",
	"19510824000130",
	"15484313000130",
	"10932933000170",
	"30594355000117",
	"10933834000103",
	"41816182000150",
	"14661394000133",
	"55925717000136",
	"16873137000190",
	"17174630000185",
	"08741679000181",
	"22463491000140",
	"05459010000294",
	"15028618000137",
	"27906656000124",
	"02440385000133",
	"02819565000120",
	"45982868000172",
	"17240206000191",
	"23317190000170",
	"79576079691",
	"28577746000181",
	"47520340000107",
	"02593631627",
	"22467509000181",
	"27198523000140",
	"52264188000189",
	"48607480000180",
	"01488218633",
	"34714681000171",
	"17210193000108",
	"18639151687",
	"40639922000168",
	"29463522000101",
	"17504194000165",
	"21025069002436",
	"22933720000142",
	"35593381000144",
	"09173639000143",
	"19926165000117",
	"13996345771",
	"40327275000159",
	"30082253000112",
	"48879694000105",
	"42536873000163",
	"30744431000123",
	"08092013000140",
	"30363962000176",
	"28020761000124",
	"00778922000124",
	"23835374000122",
	"31078473000135",
	"11019616000120",
	"21090532000137",
	"42868430000170",
	"21025069000573",
	"01328461000150",
	"32120133000198",
	"45251177000107",
	"51542897000116",
	"21025069001979",
	"10789344000428",
	"10729141000284",
	"03310811000187",
	"21025069002355",
	"19159954000170",
	"35095098000192",
	"03558873637",
	"70557888620",
	"43634860000190",
	"19726519000180",
	"21025069002860",
	"49247932000122",
	"41836654000137",
	"50056602000139",
	"10518857000151",
	"58034315001373",
	"65289662000250",
	"21251903000115",
	"05862026000162",
	"25021118000127",
	"50551004000136",
	"05247455606",
	"24270434000170",
	"30217804000299",
	"23724012000164",
	"54267665000195",
	"25016474000152",
	"28231627000172",
	"05418338000181",
	"21025069002789",
	"49447669000115",
	"03353413000148",
	"21025069003084",
	"23001533000193",
	"48826862000102",
	"22719593000183",
	"31069892000100",
	"50411962000101",
	"34070721000190",
	"32400550000194",
	"15093286000174",
	"29463542000182",
	"00626625000163",
	"16949384000123",
	"65122053000120",
	"50373820000105",
	"03891294000187",
	"21623153000165",
	"65056897000200",
];
let count = 0;
let cgc=''
// cgcs.forEach((cgc) => {
// 	// console.log({ cgc });
// 	setTimeout(() => {
// 		axios.get(`https://api.cnpjs.dev/v1/${cgc}`).then((response) => {
// 			let situa = response.data.situacao_cadastral
// 			if(situa=='Baixada') console.log({ cert: situa  });
// 			console.log({ situa  });
// 		});
		
// 	}, 30000);
// });


// for (let index = 0; index < cgcs.length; index++) {
// 	const cgc = cgcs[index];
// 	log(cgc)
// 	axios.get(`https://api.cnpjs.dev/v1/${cgc}`).then((response) => {
// 		let situa = response.data.situacao_cadastral
// 		if(situa=='Baixada') console.log({ cert: situa  });
// 		console.log({ situa  });
// 	});
// 	setTimeout(()=>{},3000)
// }

count = 0
setInterval(
    function clear() {
		
		

		// log({count})
		let cgc = cgcs[count]
		
		try {
			if (cgc.length ==14){

				axios.get(`https://api.cnpjs.dev/v1/${cgc}`).then((response) => {
				let situa = response.data.situacao_cadastral
				// console.log({ situa, cgcs: cgc  });
				if(situa!='Ativa') {
	
					console.log({ situa, cgc: cgc  });
				}
				count++
				}).catch(error =>{
				// count--
					// log({error: error.status})
					if(error.status == 404) count++
	
				})
			
		}else count++
			
		} catch (error) {
			// log(erro)
		}
		if(count == cgcs.length ){

			clearInterval(this) 
		}
		// log('count')
		// if
       return clear;
    }()
, 1000)

// cgc = '21623153000165'

// axios.get(`https://api.cnpjs.dev/v1/${cgc}`).then((response) => {
// 			console.log({ response: response.data.situacao_cadastral });
// 		});



// cgcs.forEach( async cgc =>{
// 	let url = `https://api.cnpjs.dev/v1/${cgc}`
// 	let response = await fetch(url,)
// })

// const https = require('https');

// https.get('https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY', (resp) => {
//   let data = '';

//   // Um bloco de dados foi recebido.
//   resp.on('data', (chunk) => {
//     data += chunk;
//   });

//   // Toda a resposta foi recebida. Exibir o resultado.
//   resp.on('end', () => {
//     console.log(JSON.parse(data).explanation);
//   });

// }).on("error", (err) => {
//   console.log("Error: " + err.message);
// });

// cgcs.map((cgc) => {
// 	count++
// 	log({cgc})
// 	axios
// 		.get(
// 			`https://api.cnpjs.dev/v1/${cgc}`,
// 			// `http://127.0.0.1:4000/v1/cnpj/${cnpj}`,
// 			{
// 				headers: {
// 					// Vary: "Origin, Access-Control-Request-Headers",

// 					Accept: "application/json",
// 					method: "GET",
// 				},
// 			}
// 		)
// 		.then(function (response) {
// 			let situa = response.data.situacao_cadastral;
// 			if (situa == "Baixada") {
// 				console.log({
// 					situa2: response.data.situacao_cadastral,
// 				});
// 			}
// 			console.log({situa})

// 			// manipula o sucesso da requisição
// 			// makeSituacoes(response.data.uf);
// 			// console.log(response);
// 		})
// 		.catch(function (error) {
// 			// alert("Erro ao buscar CNPJ");
// 		});
// 		// console.log({count});
// 		// console.log();

// });

// const got = require('got');

// (async () => {
//   try {
//     const response = await got('https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY', { json: true });
//     console.log(response.body.url);
//     console.log(response.body.explanation);
//   } catch (error) {
//     console.log(error.response.body);
//   }
// })();

// const axios = require('axios');

// (async () => {
//   try {
//     const response = await axios.get('https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY')
//     console.log(response.data.url);
//     console.log(response.data.explanation);
//   } catch (error) {
//     console.log(error.response.body);
//   }
// // })();
// const fetchn = require('node-fetch');

// (async () => {
//   try {

//     const response = await fetch('https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY')
//     const json = await response.json()

//     console.log(json.url);
//     console.log(json.explanation);
//   } catch (error) {
//     console.log(error.response.body);
//   }
// })();

// (async () => {
//   try {
//     const [response1, response2] = await axios.all([
//       axios.get('https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY&date=2020-03-18'),
//       axios.get('https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY&date=2020-03-17')
//     ]);
//     console.log(response1.data.url);
//     console.log(response1.data.explanation);

//     console.log(response2.data.url);
//     console.log(response2.data.explanation);
//   } catch (error) {
//     console.log(error.response.body);
//   }
// })();
