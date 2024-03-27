<template>
  <div class="category">
    <categoryTab :categorys="categorys" @on-click="categoryChange" />
    <addCategoryButton @on-click="addCategoryClick" />
  </div>

  <div class="task">
    <addTaskTab :category="category" @on-click="addTaskClick" />
    <showTask :tasks="tasks" @on-change="doneTaskChange" />
  </div>
</template>

<script setup lang="ts">
// インポート
import AccessApi from "~/api/accessApi"
process.env.NODE_TLS_REJECT_UNAUTHORIZED = "0";

// 変数宣言
const categorys = ref(await AccessApi.getCategory());
const category = ref("All Tasks");
const tasks = ref(await AccessApi.getTask(category.value));

// 関数宣言
const categoryChange = async (changeCategory: string) => {
  category.value = changeCategory;
  tasks.value = await AccessApi.getTask(category.value);
}
const addCategoryClick = async (newCategory: string) => {
  await AccessApi.addCategory(newCategory);
  categorys.value = await AccessApi.getCategory();
};
const addTaskClick = async (newTask: string) => {
  await AccessApi.addTask(newTask, category.value);
  tasks.value = await AccessApi.getTask(category.value);
}
const doneTaskChange = async (id: number) => {
  await AccessApi.doneTask(id);
}
</script>

<style>
template {
  height: 100%;
}
.category {
  float: left;
  display: inline-flex;
  flex-direction: column;
  align-items: flex-start;
  margin: 70px;
  margin-top: 100px;
  gap: 20px;
}

.task {
  float: right;
  display: inline-flex;
  flex-direction: column;
  align-items: flex-start;
  padding: 50px;
  padding-left: 100px;
  padding-right: 200px;
  border-left: 2px solid var(--border-gray);
}

addTask {
  padding: 100px
}
</style>