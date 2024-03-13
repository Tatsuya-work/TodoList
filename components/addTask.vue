<template>
  <div class="category-text">{{ category.name }}</div>
  <div class="add-task">
    <input v-model="taskName" class="add-task-form" placeholder="Add a new task" />
    <div class="add-task-button" @click="onClickButton(taskName)">Add</div>
  </div>
</template>

<script setup lang="ts">
// 変数宣言
const taskName = ref("");

// Prop定義
const category = defineProps<{
  name: string;
}>();

// Emit定義
const emit = defineEmits<{
  (e: "onClick", task: string): void;
}>();
const onClickButton = (task: string): void => {
  if (task != null && task != "") {
    taskName.value = "";
    emit("onClick", task);
  }
};
</script>

<style>
.category-text {
  font-size: 35px;
  font-weight: 900;
  color: var(--font-black);
  padding-bottom: 15px;
}

.add-task {
  display: flex;
  align-items: center;
  gap: 10px;
}

.add-task-form {
  width: 500px;
  height: 26px;
  padding: 3px 10px;
  font-size: 20px;
  border-radius: 10px;
  border: 2px solid var(--border-gray);
}

.add-task-form:focus {
  border: 2px solid var(--border-blue);
  z-index: 10;
  outline: none;
}

.add-task-button {
  cursor: pointer;
  width: 70px;
  height: 30px;
  font-size: 20px;
  font-weight: 500;
  border-radius: 60px;
  border: 2px solid var(--border-black);
  text-align: center;
}

.add-task-button:hover {
  border: 2px solid var(--border-blue);
  color: var(--font-blue);
  z-index: 10;
  outline: none;
}
</style>
