# Generated by Django 2.2.4 on 2020-05-15 22:48

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('AppOne', '0003_auto_20200515_2239'),
    ]

    operations = [
        migrations.AlterField(
            model_name='shows',
            name='release_date',
            field=models.DateTimeField(),
        ),
    ]