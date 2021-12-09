window.onload = (event) => {
    console.log('page is fully loaded');

    //   alert("Stranicata zaredi bate bate....")

    let imgEl = document.querySelector("ul.content>li img");
    let buttonAdd = document.querySelector("button.add-field");
    let buttonRem = document.querySelector("button.rem-field");
    let petUl = document.querySelector("ul.pet-form");
    let counter = petUl.children.length;
    console.log("Dqdo vadi rqpa");
    function addNewField() {
        // alert("Koi cukna butona, bate bate....");           
        counter++;
        let newLi = document.createElement("li");
        let newLabel = document.createElement("label");
        newLabel.innerHTML = `Pet ${counter}`;
        newLabel.setAttribute("for", `f${counter}`);
        newLi.appendChild(newLabel);
        let newInput = document.createElement("input");
        newInput.setAttribute(`name`, `name${counter}`);
        newInput.setAttribute("id", `f${counter}`);
        newInput.setAttribute("placeholder", `Write Pet Name ${counter}`);
        newInput.classList.add(`pet-name`);
        newLi.appendChild(newInput);

        let newRemBtn = document.createElement("button");
        newRemBtn.innerHTML = `<i class="far fa-minus-square">`;
        newRemBtn.classList.add("rem-field");
        newLi.appendChild(newRemBtn);
        petUl.appendChild(newLi);
        newRemBtn.addEventListener("click", function (event) {
            event.preventDefault()

            petUl.removeChild(newLi);
        });
    }

    function remLastField() {
        //  debugger;
        if (counter > 0) {
            petUl.removeChild(petUl.lastChild);
            counter--;
        }
    }

    buttonAdd.addEventListener("click", addNewField);

    let header = document.querySelector(`div.title>h1`);
    imgEl.addEventListener("mouseover", function (ev) {
        imgEl.setAttribute("src", "./images/02.jpg");
        header.style.display = 'none';
    })

    imgEl.addEventListener("mouseout", function (ev) {
        imgEl.setAttribute("src", "./images/01.jpg");
        header.style.display = 'block';
    })
    // buttonRem.addEventListener("click", remLastField);
};
