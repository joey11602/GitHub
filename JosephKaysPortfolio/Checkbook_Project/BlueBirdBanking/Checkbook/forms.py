from django.forms import ModelForm
from .models import Account, Transaction


#create Account Form based on Account Model
class AccountForm(ModelForm):
    class Meta:
        model = Account
        fields = '__all__'



#create Transaction Form base on transaction Model
class TransactionForm(ModelForm):
    class Meta:
        model = Transaction
        fields = '__all__'



