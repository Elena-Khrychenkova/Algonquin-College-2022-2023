function validateProfile(event) {
    event.preventDefault();
  
    let valid = true;
  //Cat name has no input
    if(profile.catname.value === '') {
        let warning = document.querySelector('#catnameWarning');
        let text = document.createTextNode('Please enter the name of your cat');
        warning.appendChild(text)
        valid = false;
    }
//The name was inputted, the warning disappears
    document.querySelector('#catname').addEventListener('blur', function() {
        if(this.value !== '') {
            catnameWarning.innerHTML = '';
        }
    });


//The owner's name has not been chosen
if(profile.flname.value === '') {
    let warning = document.querySelector('#flnameWarning');
    let text = document.createTextNode('Please enter your name');
    warning.appendChild(text)
    valid = false;
}

//User inputs the name, the warning disappears
document.querySelector('#flname').addEventListener('blur', function() {
    if(this.value !== '') {
        flnameWarning.innerHTML = '';
    }
});

//The emegency contact name was not provided
if(profile.emcontactname.value === '') {
    let warning = document.querySelector('#emcontactnameWarning');
    let text = document.createTextNode('Please enter the contact name');
    warning.appendChild(text)
    valid = false;
}

//The emegency contact name was provided, the warning disappears
document.querySelector('#emcontactname').addEventListener('blur', function() {
    if(this.value !== '') {
        emcontactnameWarning.innerHTML = '';
    }
});

//The emegency contact number was not provided
if(profile.contactphone.value === '') {
    let warning = document.querySelector('#contactphoneWarning');
    let text = document.createTextNode('Please enter the contact phone');
    warning.appendChild(text)
    valid = false;
}

//The emegency contact number was provided, the warning disappears
document.querySelector('#contactphone').addEventListener('blur', function() {
    if(this.value !== '') {
        contactphoneWarning.innerHTML = '';
    }
});

//The cell phone was not provided
if(profile.cellphone.value === '') {
    let warning = document.querySelector('#cellphoneWarning');
    let text = document.createTextNode('Please enter the cell phone');
    warning.appendChild(text)
    valid = false;
}

//The cell phone provided, the warning disappears
document.querySelector('#cellphone').addEventListener('blur', function() {
    if(this.value !== '') {
        cellphoneWarning.innerHTML = '';
    }
});

if(valid) {
    alert('Your form has been submitted successfully. Thank you!');
  }

  return valid;
};

document.profile.addEventListener('submit', validateProfile);

//Show the describe diet text area if a user chooses the special diet checkbox and hide the text area if the user unselects the special diet checkbox
function catDiet() {
    let dietlabel = document.getElementById('catdietDesc');
    let dietinput = document.getElementById('catdiet');

    if (dietlabel.style.display === 'inline') {
        dietlabel.style.display = 'none';
    }
        else {
            dietlabel.style.display = 'inline';
        };
    if (dietinput.style.display === 'inline') {
        dietinput.style.display = 'none';
    } 
        else {
            dietinput.style.display = 'inline';   
        };
    
}

//Describe territorial text box appears if a user chooses the Territotial option
function showDescrTer() {
    document.getElementById('territorialSel').style.display = 'inline';
    document.getElementById('territorialDesc').style.display = 'inline';
}

function hideDescrTer() {
    document.getElementById('territorialSel').style.display = 'none';
    document.getElementById('territorialDesc').style.display = 'none';
}

//Check if the phone number is valid (Daytime Phone input)
function phoneNum() {
    let number = /^\d{10}$/;
    if (telnumday.value.match(number))
        {
       return true;     
        }
        else
        {
            telnumdayWarning.innerHTML = 'Number should be a valid one';
            return false;
        }
}

//Check if the phone number is valid (Contact Phone input)
function phoneNum2() {
    let number = /^\d{10}$/;
    if (contactphone.value.match(number))
        {
       return true;     
        }
        else
        {
            contactphoneWarning2.innerHTML = 'Number should be a valid one';
            return false;
        }
}

//Check if the phone number is valid (Cell Phone)
function phoneNum3() {
    let number = /^\d{10}$/;
    if (cellphone.value.match(number))
        {
       return true;     
        }
        else
        {
            cellphoneWarning2.innerHTML = 'Number should be a valid one';
            return false;
        }
}

//Check if the email is valid
function emailValid() {
    let em = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    if (email.value.match(em))
        {
       return true;     
        }
        else
        {
            emailWarning.innerHTML = 'Please enter a valid email';
            return false;
        }
}
