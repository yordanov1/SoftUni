window.addEventListener('load', solution);

function solution() {

  let input = document.querySelectorAll('#form div input');
  let [name, email, number, address, code] = input;

  let btnSubmit = document.querySelector('#submitBTN');


  btnSubmit.addEventListener('click', e => {


    if (!name.value) {
      return;
    }

    if (!email.value) {
      return;
    }

    let nameLi = document.createElement('li');
    nameLi.textContent = `Full Name: ${name.value}`;

    let emailLi = document.createElement('li');
    emailLi.textContent = `Email: ${email.value}`;

    let numberLi = document.createElement('li');
    numberLi.textContent = `Phone Number: ${number.value}`;

    let addressLi = document.createElement('li');
    addressLi.textContent = `Address: ${address.value}`;

    let codeLi = document.createElement('li');
    codeLi.textContent = `Postal Code: ${code.value}`;

    let ul = document.querySelector('#infoPreview');


    ul.appendChild(nameLi);
    ul.appendChild(emailLi);
    ul.appendChild(numberLi);
    ul.appendChild(addressLi);
    ul.appendChild(codeLi);


    let btnEdit = document.querySelector('#editBTN');
    let btnContinue = document.querySelector('#continueBTN');

    btnEdit.disabled = false;
    btnContinue.disabled = false;

    let nameText = name.value;
    let emailText = email.value;
    let numberText = number.value;
    let addressText = address.value;
    let codeText = code.value;

    name.value = '';
    email.value = '';
    number.value = '';
    address.value = '';
    code.value = '';

    btnSubmit.disabled = true;

    btnEdit.addEventListener('click', e => {

      btnSubmit.disabled = true;

      name.value = nameText;
      email.value = emailText;
      number.value = numberText;
      address.value = addressText;
      code.value = codeText;

      let liAll = document.querySelectorAll('#infoPreview li');

      liAll[0].remove();
      liAll[1].remove();
      liAll[2].remove();
      liAll[3].remove();
      liAll[4].remove();

      btnEdit.disabled = true;
      btnSubmit.disabled = false;
      btnContinue.disabled = true;

    });

    btnContinue.addEventListener('click', z => {

      let h11 = document.querySelector('#block h1');
      let h4 = document.querySelector('#block h4');
      let div = document.querySelector('#block div');
      let div2 = document.querySelector('#information');
      let footer = document.querySelector('#block footer');

      h11.remove();
      h4.remove();
      div.remove();
      div2.remove();
      footer.remove();

      let block = document.querySelector('#block');
      let h3 = document.createElement('h3');
      h3.textContent = 'Thank you for your reservation!';
      block.appendChild(h3);

      btnContinue.disabled = true;

    });
  });
};
