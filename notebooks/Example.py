# Databricks notebook source
param = dbutils.widgets.get("param")

print(f"Example notebook with additional info - {param}")